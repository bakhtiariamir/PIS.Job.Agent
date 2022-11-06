namespace Parsis.Agent.Core.Base;
public interface IObjectOperation<T> : IOperation<T>
{
    T Create();
}
