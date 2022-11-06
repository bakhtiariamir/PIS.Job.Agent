using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Type.Graph;
public class Edge<T> : IEdge<T>
where T : IObject
{
    public IVertex<T> From
    {
        get;
        init;
    }

    public IVertex<T> To
    {
        get;
        init;
    }

    public int Weight
    {
        get;
        init;
    }


}

public interface IEdge<T>
where T : IObject
{
    IVertex<T> From
    {
        get;
    }

    IVertex<T> To
    {
        get;
    }

    int Weight
    {
        get;
    }
}
