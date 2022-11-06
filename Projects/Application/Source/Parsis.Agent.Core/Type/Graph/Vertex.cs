using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Type.Graph;
public class Vertex<T> : IVertex<T>
where T : IObject
{
    public int Index
    {
        get;
        set;
    }

    public T Data
    {
        get;
        set;
    }

    public List<IVertex<T>> Neighbors
    {
        get;
        set;
    }

    public List<int> Weights
    {
        get;
        set;
    }
}

public interface IVertex<T>
where T : IObject
{
    int Index
    {
        get;
        set;
    }

    T Data
    {
        get;
        set;
    }

    List<IVertex<T>> Neighbors
    {
        get;
        set;
    }

    List<int> Weights { get; set; }


}
