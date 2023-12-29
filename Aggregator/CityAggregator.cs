using Autofac;
using Domain.AggregatorContract;
using Domain.Model;
using Services;

namespace Aggregator;
public class CityAggregator : ICityAggregator
{
    private readonly IServiceManager _serviceManager;
    public CityAggregator()
    {
        IContainer container = DependencyContainer.Configure();
        _serviceManager = container.Resolve<IServiceManager>();
    }
    public async Task<List<Cities>> GetAllCities()
    {
        _serviceManager.LoggerService.Information("Succesfully get all cities.");
        return await _serviceManager.CityService.GetAll();
    }
    public async Task SendMail()
    {
        await _serviceManager.EmailService.SendSuccessfulPaymentEmail("asd123",
            "Lorem Ipsum Battle", "skelox0@gmail.com");
        _serviceManager.LoggerService.Information("Email sent.");
    }
}