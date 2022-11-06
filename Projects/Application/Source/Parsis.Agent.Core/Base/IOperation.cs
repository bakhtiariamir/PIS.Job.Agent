namespace Parsis.Agent.Core.Base;
public interface IOperation<TObject>  where TObject : IObject
{
    TObject Create();

    Task<TObject> Get(IDictionary<string, object> parameters);

    Task<IList<TObject>> GetAll(IDictionary<string, object> parameters);
}
