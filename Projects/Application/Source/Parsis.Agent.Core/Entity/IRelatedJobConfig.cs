using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Entity;
public interface IRelatedJobConfig : IEntity<int>
{
    string Job
    {
        get;
        set;
    }

    string MainJob
    {
        get;
        set;
    }
}
