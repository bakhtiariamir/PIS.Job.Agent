using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Data.Entity;
public class EndPointConfig : BaseEntity<int>, IEndpointConfig
{
    public string Name
    {
        get;
        set;
    }

    public string Url
    {
        get;
        set;
    }

    public string Application
    {
        get;
        set;
    }

    public int MaxRetry
    {
        get;
        set;
    }

    public int MinDelay
    {
        get;
        set;
    }
}
