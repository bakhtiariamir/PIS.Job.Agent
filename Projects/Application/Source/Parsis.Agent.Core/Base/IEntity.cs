namespace Parsis.Agent.Core.Base;
public interface IEntity<TType> :IObject
{
    TType Id
    {
        get;
        set;
    }
}
