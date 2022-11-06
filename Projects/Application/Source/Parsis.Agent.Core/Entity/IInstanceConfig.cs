using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Entity;
public interface IInstanceConfig : IEntity<int>
{
    string Name
    {
        get;
        set;
    }

    string Address
    {
        get;
        set;
    }

    IEnumerable<string> Jobs
    {
        get;
        set;
    }
}
