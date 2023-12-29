using Domain.ServiceContract;

namespace Services;
public interface IServiceManager
{
    ICityService CityService { get; }
    IEmailService EmailService { get; }
    ILoggerService LoggerService { get; }
}