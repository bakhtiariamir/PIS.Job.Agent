using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Type.Graph;
public class Graph<T> : IGraph<T>
where T : IObject
{
    public virtual bool IsWeighted
    {
        get;
    }

    public virtual bool IsDirected
    {
        get;
    }

    public List<IVertex<T>> Vertexes
    {
        get;
        set;
    } = new List<IVertex<T>>();

    public List<IEdge<T>> Edges
    {
        get;
        set;
    } = new List<IEdge<T>>();

    public IEdge<T> this[int from, int to]
    {
        get
        {
            IVertex<T> nodeFrom = Vertexes[from];
            IVertex<T> nodeTo = Vertexes[to];
            int i = nodeFrom.Neighbors.IndexOf(nodeTo);
            if (i >= 0)
            {
                var edge = new Edge<T>()
                {
                    From = nodeFrom,
                    To = nodeTo,
                    Weight = i < nodeFrom.Weights.Count ? nodeFrom.Weights[i] : 0
                };
                return edge;
            }

            return null;
        }
    }


    public Graph()
    {
    }
}

public interface IGraph<T>
where T : IObject
{
    bool IsWeighted
    {
        get;
    }

    bool IsDirected
    {
        get;
    }

    List<IVertex<T>> Vertexes
    {
        get;
        set;
    }

    List<IEdge<T>> Edges
    {
        get;
        set;
    }
}