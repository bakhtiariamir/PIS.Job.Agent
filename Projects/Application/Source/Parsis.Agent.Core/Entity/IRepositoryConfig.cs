namespace Parsis.Agent.Core.Entity;
public interface IRepositoryConfig
{
    string Name
    {
        get;
        set;
    }

    string Type
    {
        get;
        set;
    }

    string Address
    {
        get;
        set;
    }

    IEnumerable<IRepositoryEntityConfig> RepositoryEntityConfigs
    {
        get;
        set;
    }
}

//علایم در روز
//    احساساتی که الان تو روز داری
//    دوست داری برای روند درمانت و حس کنی
