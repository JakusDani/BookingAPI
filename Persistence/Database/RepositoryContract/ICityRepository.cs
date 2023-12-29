using Database.Entity;

namespace Database.RepositoryContract;
public interface ICityRepository
{
    Task<List<CitiesEntity>> GetAll();
}