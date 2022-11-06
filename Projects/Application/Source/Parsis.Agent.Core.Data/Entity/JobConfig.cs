using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Data.Entity;
public class JobConfig : BaseEntity<int>, IJobConfig
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

    public int DelayRun
    {
        get;
        set;
    }
}
