namespace Parsis.Agent.Core.Entity;
public interface IRepositoryEntityConfig
{
    string EntityName
    {
        get;
        set;
    }

    string Path
    {
        get;
        set;
    }

    IDictionary<string, object> Parameters
    {
        get;
        set;
    }
}
