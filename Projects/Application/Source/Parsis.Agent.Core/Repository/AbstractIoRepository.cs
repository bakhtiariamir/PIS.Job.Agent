using Parsis.Agent.Core.Base;
using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Repository;
public abstract class AbstractIoRepository<TEntity, TType> : AbstractRepositoryFactory<TEntity, TType> where TEntity :IEntity<TType>
{
    protected AbstractIoRepository(IRepositoryConfig config) : base(config)
    {
    }

    public override IRepository<TEntity, TType> Create(TEntity entity)
    {
        return new IoRepository<TEntity, TType>(Config);
    }


}

