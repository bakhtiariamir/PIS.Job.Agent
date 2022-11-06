using Parsis.Agent.Core.Base;
using Parsis.Agent.Core.Type.Graph;

namespace Parsis.Agent.Core.Entity;
public interface IRedoJobOperation : IOperation<IRedoJob>
{
    IVertex<IRedoJob> AddJob(IRedoJob job);

    void RemoveJob(IRedoJob job);

    void RemoveJob(string job, string instance);

    IEnumerable<IRedoJob> GetAllRedoJobs();

    IEnumerable<IRedoJob> GetAllRedoJobs(string job);
    IEnumerable<IRedoJob> GetAllRedoJobs(string job, string instance);

    IRedoJob GetRedoJob(string job, string instance);

    IEnumerable<IRedoJob> GetAllDependentRedoJobs(string job);

    IEnumerable<IRedoJob> GetAllDependentRedoJobs(string job, string instance);

    IEnumerable<IRedoJob> GetAllMainRedoJobs(string job);

    IEnumerable<IRedoJob> GetAllMainRedoJobs(string job, string instance);
}
