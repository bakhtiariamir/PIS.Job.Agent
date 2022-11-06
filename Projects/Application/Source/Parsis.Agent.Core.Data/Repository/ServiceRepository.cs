using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Parsis.Agent.Core.Base;
using Parsis.Agent.Core.Entity;
using Parsis.Agent.Core.Exception;

namespace Parsis.Agent.Core.Data.Repository;
public class ServiceRepository<TEntity, TType> : BaseRepository<TEntity, TType>, IServiceRepository<TEntity, TType> where TEntity : IEntity<TType>
{
    private HttpClient _client;
    private readonly IRepositoryConfig _config;
    private readonly IRepositoryEntityConfig _entityConfig;
    private readonly CancellationToken _cancellationToken;

    public ServiceRepository(IRepositoryConfig config, System.Type entityType) : base(config, entityType)
    {
        _config = config;
        _entityConfig = config.RepositoryEntityConfigs.FirstOrDefault(entity => entity.EntityName == entityType.FullName);
        if (_entityConfig == null)
            throw new ConfigNotFound(ExceptionCode.RepositoryEntityConfigNotFoundException, $"Not found any configuration for {entityType.FullName}");

        _cancellationToken = new CancellationToken();

        _client = new HttpClient()
        {
            BaseAddress = new Uri(config.Address)
        };
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public override async Task Save(TEntity entity)
    {
        using var client = _client;
        var result = await client.PostAsJsonAsync(_entityConfig.Path, entity, _cancellationToken);

        if (result.IsSuccessStatusCode)
        {

        }
        else
        {
            //Set Repository.Save Exception
            throw new System.Exception();
        }
    }

    public override async Task Delete(TEntity entity)
    {
        await Delete(entity.Id);
    }

    public override async Task Delete(TType id)
    {
        using var client = _client;
        var deleteUri = new Uri($"_entityConfig.Path/{id}");
        var result = await client.DeleteAsync(deleteUri, _cancellationToken);
        if (result.IsSuccessStatusCode)
        {

        }
        else
        {
            //Set Repository.Save Exception
            throw new System.Exception();
        }
    }

    public override Task<TEntity> Get(TType id)
    {

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

