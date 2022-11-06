using Parsis.Agent.Core.Entity;
using Parsis.Agent.Core.Type;

namespace Parsis.Agent.Core.Job;
public interface IRunner
{
    IJobProcess JobProcess
    {
        get;
        set;
    }

    RunnerType RunnerType
    {
        get;
    }

    Task RunAsync();
}
