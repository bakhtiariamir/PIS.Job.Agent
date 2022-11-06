namespace Parsis.Agent.Core.Base;
public interface ISqlRepository<TEntity, in TType> : IRepository<TEntity, TType> where TEntity : IEntity<TType>
{
}
