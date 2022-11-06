using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Entity;
public interface IJobConfig : IEntity<int>
{
    string Name
    {
        get;
        set;
    }

    string FullName
    {
        get;
        set;
    }

    int Order
    {
        get;
        set;
    }

    int DelayRun
    {
        get;
        set;
    }
}
