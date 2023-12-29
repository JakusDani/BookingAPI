using Database;
using Database.Entity;
using Domain.Model;
using Domain.ServiceContract;

namespace Services;
internal class CityService : ICityService
{
    private readonly IRepositoryManager _database;
    public CityService(IRepositoryManager database)
    {
        _database = database;
    }
    public async Task<List<Cities>> GetAll()
    {
        List<CitiesEntity> cities = await _database.CityRepository.GetAll();
        return cities.Select(x => new Cities(x.ID, x.FullName, x.CountryID)).ToList();
    }
}
