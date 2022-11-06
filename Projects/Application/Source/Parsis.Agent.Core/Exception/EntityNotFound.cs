namespace Parsis.Agent.Core.Exception;
public class EntityNotFound : ParsisException
{
    public EntityNotFound(string? code, string? message) : base(code ?? ExceptionCode.EntityNotFoundException, message)
    {
    }

    public EntityNotFound(string? code, string? message, System.Exception? innerException) : base(code ?? ExceptionCode.EntityNotFoundException, message, innerException)
    {
    }
}
