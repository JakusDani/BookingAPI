using Database.Entity;
using Database.RepositoryContract;
using Supabase;

namespace Database.Repository;
internal class CityRepository : ICityRepository
{
    private readonly Client _database;

    public CityRepository(Client database)
    {
        _database = database;
    }
    public async Task<List<CitiesEntity>> GetAll()
    {
        var result = await _database.From<CitiesEntity>().Get();
        return result.Models;
    }
}
