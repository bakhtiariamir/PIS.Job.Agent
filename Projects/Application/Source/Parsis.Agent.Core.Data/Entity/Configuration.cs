using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Data.Entity;
public class Configuration : IConfiguration
{
    public IRepositoryConfig RepositoryConfig
    {
        get;
        set;
    }

    public IEnumerable<IEndpointConfig> EndPoints
    {
        get;
        set;
    }

    public IEnumerable<IScheduleConfig> Schedules
    {
        get;
        set;
    }

    public IEnumerable<IJobConfig> Jobs
    {
        get;
        set;
    }

    public IEnumerable<IRelatedJobConfig> RelatedJobs
    {
        get;
        set;
    }

    public IEnumerable<IInstanceConfig> Instances
    {
        get;
        set;
    }
}
