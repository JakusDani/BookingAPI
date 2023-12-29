public class MissingDatabasePropertiesException : Exception
{
    public MissingDatabasePropertiesException() { }
    public MissingDatabasePropertiesException(string name)
        : base(string.Format("The {name} is missing", name))
    {

    }
}