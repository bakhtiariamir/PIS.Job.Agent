using Parsis.Agent.Core.Base;
using Parsis.Agent.Core.Type;

namespace Parsis.Agent.Core.Entity;
public interface IJobProcessStep : IObject
{
    int Index
    {
        get;
        set;
    }

    string Trigger
    {
        get;
        set;
    }
    
    string Service
    {
        get;
        set;
    }

    ServiceStatusType ServiceStatusType
    {
        get;
        set;
    }

    int ExecutionCount
    {
        get;
        set;
    }

    long ExecutionTime
    {
        get;
        set;
    }

    string Message
    {
        get;
        set;
    }

    string Data
    {
        get;
        set;
    }

    T? DeserializeObject<T>();

    string SerializableObject(object data);
}
