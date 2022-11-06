namespace Parsis.Agent.Core.Base;
public interface IServiceRepository<TEntity, in TType> : IRepository<TEntity, TType> where TEntity : IEntity<TType>
{

}
