using Parsis.Agent.Core.Base;

namespace Parsis.Agent.Core.Type.Graph;
public class Subset<T> : ISubset<T>
where T : IObject
{
    public IVertex<T> Parent
    {
        get;
        set;
    }

    public int Rank
    {
        get;
        set;
    }
}

public interface ISubset<T> 
where T : IObject
{
    IVertex<T> Parent
    {
        get;
        set;
    }

    int Rank
    {
        get;
        set;
    }
}
