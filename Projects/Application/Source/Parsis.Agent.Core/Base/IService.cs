using Parsis.Agent.Core.Type;

namespace Parsis.Agent.Core.Base;
public interface IService : IObject
{
    int ExecutionTryCount
    {
        get;
        set;
    }

    string Message
    {
        get;
        set;
    }

    ServiceStatusType ServiceStatus
    {
        get;
        set;
    }

    string RetryDescription
    {
        get;
        set;
    }
}

