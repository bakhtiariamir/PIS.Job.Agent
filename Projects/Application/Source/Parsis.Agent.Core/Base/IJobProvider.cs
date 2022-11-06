using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Base;
public interface IJobProvider
{
    Task<List<IInstanceConfig>> LoadAsync();
}
