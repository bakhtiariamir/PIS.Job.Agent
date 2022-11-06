using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Entity;
public interface IScheduleConfig : IEntity<int>
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

    string Corn
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
