using BackgroundLogger;
using Database;
using Domain.ServiceContract;
using EmailSender;

namespace Services;
public class ServiceManager : IServiceManager
{
    private readonly Lazy<ICityService> _lazyCityService;
    private readonly Lazy<IEmailService> _lazyEmailService;
    private readonly Lazy<ILoggerService> _lazyLoggerService;
    public ServiceManager(IRepositoryManager repositoryManager, IEmailManager emailManager,
        IMyLogger logger)
    {
        _lazyCityService = new Lazy<ICityService>(() => new CityService(repositoryManager));
        _lazyEmailService = new Lazy<IEmailService>(() => new EmailService(emailManager));
        _lazyLoggerService = new Lazy<ILoggerService>(() => new LoggerService(logger));
    }

    public ICityService CityService => _lazyCityService.Value;
    public IEmailService EmailService => _lazyEmailService.Value;
    public ILoggerService LoggerService => _lazyLoggerService.Value;
}