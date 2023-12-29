namespace Domain.ServiceContract;
public interface IEmailService
{
    Task SendSuccessfulPaymentEmail(string orderId, string eventName, string toAddress);
}