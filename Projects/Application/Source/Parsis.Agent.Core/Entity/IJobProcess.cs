using Parsis.Agent.Core.Base;
using Parsis.Agent.Core.Type;

namespace Parsis.Agent.Core.Entity;
public interface IJobProcess  : IEntity<Guid>
{
    long StartDate
    {
        get;
        set;
    }

    long StopDate
    {
        get;
        set;
    }
    long ExecutionDuration
    {
        get;
        set;
    }

    string JobName
    {
        get;
        set;
    }

    List<IJobProcessStep> Steps
    {
        get;
        set;
    }

    string RawSteps
    {
        get;
        set;
    }

    ProcessStatusType ProcessStatusType
    {
        get;
        set;
    }

    IJobProcess MainJobProcess
    {
        get;
        set;
    }

    string Instance
    {
        get;
        set;
    }

    IEnumerable<IJobProcessStep>? DeserializeObject();

    string SerializableObject(object data);
}