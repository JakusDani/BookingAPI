using Database.Repository;
using Database.RepositoryContract;
using Supabase;

namespace Database;
public class RepositoryManager : IRepositoryManager
{
    private readonly Lazy<ICityRepository> _lazyCityRepository;
    public RepositoryManager()
    {
        DotNetEnv.Env.Load();
        Client database = new(
            Environment.GetEnvironmentVariable("DATABASE_API_URL")
                ?? throw new MissingDatabasePropertiesException("Api url"),
            Environment.GetEnvironmentVariable("DATABASE_API_KEY")
                ?? throw new MissingDatabasePropertiesException("Api key"));
        _lazyCityRepository = new Lazy<ICityRepository>(() => new CityRepository(database));
    }
    public ICityRepository CityRepository => _lazyCityRepository.Value;
}