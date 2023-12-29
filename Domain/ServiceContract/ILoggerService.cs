namespace Domain.ServiceContract;
public interface ILoggerService
{
    void Information(string message);
    void Warning(string message);
    void Warning(Exception ex, string message);
    void Error(Exception ex, string message, string innerEx, string stackTrace);
}