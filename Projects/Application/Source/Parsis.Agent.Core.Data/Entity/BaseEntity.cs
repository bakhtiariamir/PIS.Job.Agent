using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Data.Entity;
public class BaseEntity<TType> : IEntity<TType>
{
    public TType Id
    {
        get;
        set;
    }
}
