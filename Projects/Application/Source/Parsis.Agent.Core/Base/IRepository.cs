using System.Linq.Expressions;
using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Base;
public interface IRepository<TEntity, in TType> where TEntity : IEntity<TType>
{
    IRepositoryConfig Config
    {
        get;
    }

    Task Save(TEntity entity);

    Task Delete(TEntity entity);

    Task Delete(TType id);

    Task<TEntity> Get(TType id);

    Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

    Task<IList<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate);

    Task<IList<TEntity>> GetAll();
}
