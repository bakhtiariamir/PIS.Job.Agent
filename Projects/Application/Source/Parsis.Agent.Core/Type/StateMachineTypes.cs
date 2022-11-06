namespace Parsis.Agent.Core.Type;

public enum NavStates
{
    Unknown = 0,
    Start = 1,
    Init = 2,
    GetClientData = 3,
    GetServerData = 4,
    Compare = 5,
    Load = 6,
    Update = 7,
    Done = 8
}

public enum NavTrigger
{
    Unknown = 0,
    InitJobProcess = 1,
    GetLastClientNav = 2,
    GetServerSelectedNav = 3,
    CompareNavps = 4,
    GetFirstInvalidServerNav = 5,
    GetFirstInvalidClientNav = 5,
    GetNavps = 6,
    UpdateClientNavps = 7,
    Done = 8
}

public enum InstanceInfoStates
{
    Unknown = 0,
    Start = 1,
    GetData = 2,
    Update = 3,
    Done = 4
}

public enum InstanceInfoTrigger
{
    Unknown = 0,
    GetInstanceInformation = 1,
    UpdateConfiguration = 2,
    ValidateResult = 3,
    //this trigger use when service is done 
    Done = 4
}