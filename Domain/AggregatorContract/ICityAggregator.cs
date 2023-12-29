using Domain.Model;

namespace Domain.AggregatorContract;
public interface ICityAggregator
{
    Task<List<Cities>> GetAllCities();
    Task SendMail();
}