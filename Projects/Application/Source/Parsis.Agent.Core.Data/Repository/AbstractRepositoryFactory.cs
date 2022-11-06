using Parsis.Agent.Core.Base;
using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Data.Repository;

public abstract class AbstractRepositoryFactory<TEntity, TType> : IRepositoryFactory<TEntity, TType> where TEntity : IEntity<TType>
{
    public IRepositoryConfig Config
    {
        get;
        set;
    }
    protected AbstractRepositoryFactory(IRepositoryConfig config)
    {
        Config = config;
    }

    public abstract IRepository<TEntity, TType> Create(System.Type entityType, TEntity entity);
}
