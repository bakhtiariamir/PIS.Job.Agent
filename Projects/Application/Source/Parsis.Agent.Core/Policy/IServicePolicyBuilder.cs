using Parsis.Agent.Core.Base;
using Polly.Wrap;

namespace Parsis.Agent.Core.Policy;
public interface IServicePolicyBuilder
{
    AsyncPolicyWrap<TResult> HttpPolicy<TResult>(int maxRetry) where TResult : IService, new(); 
}