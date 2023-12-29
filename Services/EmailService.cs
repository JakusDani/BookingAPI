using Domain.ServiceContract;
using EmailSender;

namespace Services;
internal class EmailService : IEmailService
{
    private readonly IEmailManager _emailManager;
    public EmailService(IEmailManager emailManager)
    {
        _emailManager = emailManager;
    }
    public async Task SendSuccessfulPaymentEmail(string orderId, string eventName, string toAddress)
    {
        string subject = "Sikeres vásárlás";
        string body = $"Köszönjük hogy jelentkezett a {eventName} nevű eseményre " +
            $"az ön rendelési azonosítója: {orderId}";
        await _emailManager.SendEMail(subject, body, toAddress);
    }
}
