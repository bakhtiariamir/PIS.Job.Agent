using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Type.Graph;

public interface IGraphBuilder<T>
    where T : IObject
{
    IVertex<T> AddVertex(T data);

    IVertex<T> FindVertex(T data);

    IVertex<T> FindVertex(Func<IVertex<T>, bool> predicate);

    IEnumerable<T> GetAllData();

    IEnumerable<T> GetAllData(Func<IVertex<T>, bool> predicate);

    IEnumerable<T> GetAllMainVertex(Func<IVertex<T>, bool> predicate);

    IEnumerable<T> GetAllDependentVertex(Func<IVertex<T>, bool> predicate);

    void AddEdge(IVertex<T> from, IVertex<T> to, int weight = 0);

    void RemoveVertex(IVertex<T> vertex);

    void RemoveEdge(IVertex<T> from, IVertex<T> to);

    List<IEdge<T>> GetEdges();

    void UpdateIndices();

    #region Minimum Spanning Tree (Kruskal)
    List<Edge<T>> MinimumSpanningTreeKruskal();

    IVertex<T> GetRoot(ISubset<T>[] subsets, IVertex<T> IVertex);

    void Union(ISubset<T>[] subsets, IVertex<T> first, IVertex<T> second);
    #endregion

    #region Minimum Spanning Tree (Prim)
    List<IEdge<T>> MinimumSpanningTreePrim();

    int GetMinimumWeightIndex(int[] weights, bool[] isInMST);
    #endregion

    #region Shortest Path
    List<IEdge<T>> GetShortestPathDijkstra(IVertex<T> source, IVertex<T> target);

    #endregion

    #region Coloring
    int[] Color();
    #endregion

    #region Auxiliary

    void Fill<Q>(Q[] array, Q value);
    #endregion

    #region Traversal
    List<IVertex<T>> DFS();
    void DFS(bool[] isExplored, IVertex<T> IVertex, List<IVertex<T>> result);
    List<IVertex<T>> BFS();
    List<IVertex<T>> BFS(IVertex<T> IVertex);

    #endregion

}
