namespace Parsis.Agent.Core.Base;

public interface IIoRepository<TEntity, in TType> : IRepository<TEntity, TType> where TEntity : IEntity<TType>
{

}

