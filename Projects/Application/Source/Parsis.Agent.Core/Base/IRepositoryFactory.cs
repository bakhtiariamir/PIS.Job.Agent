namespace Parsis.Agent.Core.Base;
public interface IRepositoryFactory<TEntity, TType> where TEntity : IEntity<TType>
{
    IRepository<TEntity, TType> Create(System.Type entityType, TEntity entity);
}

