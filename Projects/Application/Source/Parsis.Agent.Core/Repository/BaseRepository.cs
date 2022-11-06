using System.Linq.Expressions;
using Parsis.Agent.Core.Base;
using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Repository;
public abstract class BaseRepository<TEntity, TType> : IRepository<TEntity, TType> where TEntity :IEntity<TType>
{
    protected BaseRepository(IRepositoryConfig config)
    {
        Config = config;
    }

    public IRepositoryConfig Config
    {
        get;
        set;
    }

    public abstract Task Save(TEntity entity);

    public abstract Task Delete(TEntity entity);

    public abstract Task Delete(TType id);

    public abstract Task<TEntity> Get(TType id);

    public abstract Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

    public abstract Task<IList<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate);

    public abstract Task<IList<TEntity>> GetAll();
}

