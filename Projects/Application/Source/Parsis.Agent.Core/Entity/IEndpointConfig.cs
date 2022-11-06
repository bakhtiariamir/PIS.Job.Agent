using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Entity;
public interface IEndpointConfig : IEntity<int>
{
    string Name
    {
        get;
        set;
    }

    string Url
    {
        get;
        set;
    }

    string Application
    {
        get;
        set;
    }

    int MaxRetry
    {
        get;
        set;
    }

    /// <summary>
    /// Unit is millisecond
    /// </summary>
    int MinDelay
    {
        get;
        set;
    }
}
