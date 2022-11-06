using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Entity;
public interface IJobProcessOperation : IOperation<IJobProcess>
{
    void AddStep(IJobProcess jobProcess, IJobProcessStep jobProcessStep);

    IJobProcessStep CreateStep();
}
