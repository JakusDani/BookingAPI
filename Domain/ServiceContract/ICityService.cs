using Domain.Model;

namespace Domain.ServiceContract;
public interface ICityService
{
    Task<List<Cities>> GetAll();
}