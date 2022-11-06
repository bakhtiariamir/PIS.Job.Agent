using System.Linq.Expressions;
using Parsis.Agent.Core.Base;
using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Data.Repository;
public class IoRepository<TEntity, TType> : BaseRepository<TEntity, TType>, IIoRepository<TEntity, TType> where TEntity : IEntity<TType>
{
    public IoRepository(IRepositoryConfig config) : base(config)
    {

    }

    public override Task Save(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public override Task Delete(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public override Task Delete(TType id)
    {
        throw new NotImplementedException();
    }

    public override Task<TEntity> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IList<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IList<TEntity>> GetAll()
    {
        throw new NotImplementedException();
    }
}

