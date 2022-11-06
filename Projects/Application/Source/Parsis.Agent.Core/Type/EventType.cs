namespace Parsis.Agent.Core.Type;
public class EventType
{

    public const int CreateScheduler = 200;
    public const int CreateJob = 300;
    public const int ProvidingInstanceInfoJobs = 400;
    public const int ProvidingJobs = 405;
    public const int ExecuteJob = 450;
    public const int ExecutePipelineJobStep = 451;
    public const int ExecuteStatelessJobStep = 452;
    public const int StateMachineExecuteAgainJobProcess = 500;
}
