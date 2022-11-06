namespace Parsis.Agent.Core.Exception;
public class ConfigNotFound : ParsisException
{
    public ConfigNotFound() : base(ExceptionCode.ConfigurationNotFoundException)
    {
    }

    public ConfigNotFound(string? code, string? message) : base(code ?? ExceptionCode.ConfigurationNotFoundException, message)
    {
    }

    public ConfigNotFound(string? code, string? message, System.Exception? innerException) : base(code ?? ExceptionCode.ConfigurationNotFoundException, message, innerException)
    {
    }
}
