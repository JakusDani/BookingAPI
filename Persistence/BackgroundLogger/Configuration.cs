using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Formatting.Json;

namespace BackgroundLogger;
public abstract class Configuration
{
    internal ILogger ConfigSerilog()
    {
        string workingDirectory = AppDomain.CurrentDomain.BaseDirectory;
        var configuration = new ConfigurationBuilder()
        .SetBasePath(workingDirectory)
        .AddJsonFile("appsettings.json")
        .Build();
        return new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .WriteTo
            .File(new JsonFormatter(),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs/BookingLog-.json"),
                 rollingInterval: RollingInterval.Day,
                 retainedFileCountLimit: 30)
            .CreateLogger();
    }
}