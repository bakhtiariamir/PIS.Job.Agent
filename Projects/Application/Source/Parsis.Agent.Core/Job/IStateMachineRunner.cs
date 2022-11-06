using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Job;
public interface IStateMachineRunner<TState, in TTrigger> : IStateMachineRunner
where TState : Enum
where TTrigger : Enum
{
    TState CurrentState
    {
        get;
        set;
    }

    Task RunAsync(TTrigger startTrigger);

    Task FireMachineAsync(TTrigger trigger, bool isAutomate);
}

public interface IStateMachineRunner : IRunner
{
    IConfiguration Configuration
    {
        get;
        set;
    }

    Task InitMachineAsync(IDictionary<string, object> parameters);

    Task FireMachineAsync();

    Task StoppedProcessContinueExecuteAsync(IJobProcess jobProcess, bool isAutomate);
}