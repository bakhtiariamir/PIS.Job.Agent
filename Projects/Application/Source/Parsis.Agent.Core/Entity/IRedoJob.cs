using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Entity;

public interface IRedoJob : IEntity<int>
{
    string Schedule
    {
        get;
        set;
    }

    long ExecuteDateTime
    {
        get;
        set;
    }

    string Instance
    {
        get;
        set;
    }

    string JobName
    {
        get;
        set;
    }

    IJobProcess JobProcess
    {
        get;
        set;
    }
}
