using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Entity;
public interface IJobProcessStepOperation : IOperation<IJobProcessStep>
{
    List<IJobProcessStep> CreateSteps();
}
