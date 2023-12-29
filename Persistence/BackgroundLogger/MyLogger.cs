using Serilog;

namespace BackgroundLogger;
public class MyLogger : Configuration, IMyLogger
{
    private readonly ILogger _logger;
    public MyLogger()
    {
        _logger = ConfigSerilog();
    }
    public void Information(string message)
    {
        _logger.Information(message);
    }
    public void Warning(string message)
    {
        _logger.Warning(message);
    }
    public void Warning(Exception ex, string message)
    {
        _logger.Warning(ex, message);
    }
    public void Error(Exception ex, string message, string innerEx)
    {
        _logger.Error(ex, message, innerEx);
    }
}
