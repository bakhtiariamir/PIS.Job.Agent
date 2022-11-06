using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Data.Entity;
public class RepositoryEntityConfig : IRepositoryEntityConfig
{
    public string EntityName
    {
        get;
        set;
    }

    public string Path
    {
        get;
        set;
    }

    public IDictionary<string, object> Parameters
    {
        get;
        set;
    }
}
