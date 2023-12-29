public class MissingEmailPropertiesException : Exception
{
    public MissingEmailPropertiesException() { }
    public MissingEmailPropertiesException(string propName)
        : base(string.Format("{propName} email properties is missing", propName))
    {

    }
}