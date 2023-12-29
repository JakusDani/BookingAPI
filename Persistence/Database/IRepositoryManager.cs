using Database.RepositoryContract;

namespace Database;
public interface IRepositoryManager
{
    ICityRepository CityRepository { get; }
}