namespace EmailSender;
public interface IEmailManager
{
    Task SendEMail(string subject, string body, string toAddress);
}