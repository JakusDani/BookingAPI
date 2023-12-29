using BackgroundLogger;
using Domain.ServiceContract;

namespace Services;
internal class LoggerService : ILoggerService
{
    private readonly IMyLogger _logger;
    public LoggerService(IMyLogger logger)
    {
        _logger = logger;
    }
    public void Error(Exception ex, string message, string innerEx, string stackTrace)
    {
        _logger.Error(ex, message, $"{innerEx}\n{stackTrace}");
    }
    public void Information(string message)
    {
        _logger.Information(message);
    }
    public void Warning(string message)
    {
        _logger.Warning(message);
        throw new NotImplementedException();
    }
    public void Warning(Exception ex, string message)
    {
        _logger.Warning(ex, message);
        throw new NotImplementedException();
    }
}
