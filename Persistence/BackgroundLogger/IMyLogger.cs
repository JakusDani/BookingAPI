namespace BackgroundLogger;
public interface IMyLogger
{
    void Information(string message);
    void Warning(string message);
    void Warning(Exception ex, string message);
    void Error(Exception ex, string message, string innerEx);
}