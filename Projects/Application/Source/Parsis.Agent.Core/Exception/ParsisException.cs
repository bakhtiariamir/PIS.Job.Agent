using Parsis.Agent.Core.Helper;

namespace Parsis.Agent.Core.Exception;
public class ParsisException : System.Exception
{
    public string Code
    {
        get;
        private set;
    }

    public string CodeName
    {
        get;
    }

    public ParsisException(string code)
    {
        Code = code;
        CodeName = code.GetCodeName();
    }

    public ParsisException(string code, string? message) : base(message)
    {
        Code = code;
        CodeName = code.GetCodeName();
    }

    public ParsisException(string code, string? message, System.Exception? innerException) : base(message, innerException)
    {
        Code = code;
        CodeName = code.GetCodeName();
    }
}
