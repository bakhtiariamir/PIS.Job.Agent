using Polly.Wrap;

namespace Parsis.Agent.Core.Policy;
public interface IPolicyBuilder
{
    AsyncPolicyWrap GetHttpPolicy();
}

