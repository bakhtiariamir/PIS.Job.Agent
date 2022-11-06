using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Data.Entity; 
public class ScheduleConfig : BaseEntity<int>, IScheduleConfig
{
    public string Name
    {
        get;
        set;
    }

    public string FullName
    {
        get;
        set;
    }

    public int Order
    {
        get;
        set;
    }

    public string Corn
    {
        get;
        set;
    }

    public IEnumerable<string> Jobs
    {
        get;
        set;
    }
}
