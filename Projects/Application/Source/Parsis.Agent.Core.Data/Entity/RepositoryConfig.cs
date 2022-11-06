using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Data.Entity;
public class RepositoryConfig : IRepositoryConfig
{
    public string Name
    {
        get;
        set;
    }

    public string Type
    {
        get;
        set;
    }

    public string Address
    {
        get;
        set;
    }

    public IEnumerable<IRepositoryEntityConfig> RepositoryEntityConfigs
    {
        get;
        set;
    }
}
