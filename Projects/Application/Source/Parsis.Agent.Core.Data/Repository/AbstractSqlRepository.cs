using Parsis.Agent.Core.Base;
using Parsis.Agent.Core.Entity;

namespace Parsis.Agent.Core.Data.Repository;
public abstract class AbstractSqlRepository<TEntity, TType> : AbstractRepositoryFactory<TEntity, TType> where TEntity :IEntity<TType>
{
    protected AbstractSqlRepository(IRepositoryConfig config) : base(config)
    {
    }

    public override IRepository<TEntity, TType> Create(TEntity entity)
    {
        return new SqlRepository<TEntity, TType>(Config);
    }
}

