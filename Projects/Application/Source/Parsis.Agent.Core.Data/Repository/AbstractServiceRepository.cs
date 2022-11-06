using Parsis.Agent.Core.Base;
using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Data.Repository;

public abstract class AbstractServiceRepository<TEntity, TType> : AbstractRepositoryFactory<TEntity, TType> where TEntity : IEntity<TType>
{ 
    protected AbstractServiceRepository(IRepositoryConfig config) : base(config)
    {
    }

    public override IRepository<TEntity, TType> Create(System.Type entityType, TEntity entity)
    {
        return new ServiceRepository<TEntity, TType>(Config);
    }
}

