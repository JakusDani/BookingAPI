using MailKit.Net.Smtp;
using MimeKit;

namespace EmailSender;
public class EmailManager : IEmailManager
{
    private MimeMessage _mailMessage;
    private string _hostAddress;
    private string _userName;
    private string _password;
    private int _port;
    private bool _ssl;
    public EmailManager()
    {
        DotNetEnv.Env.Load();
        _mailMessage = new MimeMessage();
        _hostAddress = Environment.GetEnvironmentVariable("EMAIL_HOST")
            ?? throw new MissingEmailPropertiesException("Host name");
        _userName = Environment.GetEnvironmentVariable("EMAIL_USERNAME")
            ?? throw new MissingEmailPropertiesException("User name");
        _password = Environment.GetEnvironmentVariable("EMAIL_PASSWORD")
            ?? throw new MissingEmailPropertiesException("Password");
        _port = int.Parse(Environment.GetEnvironmentVariable("EMAIL_PORT")
            ?? throw new MissingEmailPropertiesException("Port"));
        _ssl = bool.Parse(Environment.GetEnvironmentVariable("EMAIL_SSL")
            ?? throw new MissingEmailPropertiesException("Ssl"));
    }
    private void AddBody(string body)
    {
        _mailMessage.Body = new TextPart("plain")
        {
            Text = body
        };
    }
    private void AddFromEmail(string name)
    {
        _mailMessage.From.Add(new MailboxAddress(name, _userName));
    }
    private void AddSubject(string subject)
    {
        _mailMessage.Subject = subject;
    }
    private void AddToEmail(string name, string email)
    {
        _mailMessage.To.Add(new MailboxAddress(name, email));
    }
    public async Task SendEMail(string subject, string body, string toAddress)
    {
        AddFromEmail(string.Empty);
        AddSubject(subject);
        AddBody(body);
        AddToEmail(string.Empty, toAddress);
        using (var smtpClient = new SmtpClient())
        {
            smtpClient.Connect(_hostAddress, _port, _ssl);
            smtpClient.Authenticate(_userName, _password);
            await smtpClient.SendAsync(_mailMessage);
            smtpClient.Disconnect(true);
        }
    }
}
