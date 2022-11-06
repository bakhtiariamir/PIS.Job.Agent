namespace Parsis.Agent.Core.Helper;
public static class ExceptionHelper
{
    public static string GetCodeName(this string code)
    {
        return code.Split('.')[0] switch
        {
            "1000" => GetNotFoundCodeName(code),
            _ => "Exception_Occurred"
        };
    }

    private static string GetNotFoundCodeName(string code)
    {
        return code.Split('.')[1] switch
        {
            "1" => GetConfigurationCodeName(code),
            "2" => GetEntityCodeName(code),
            _ => "Item_Not_Found",
        };
    }

    private static string GetEntityCodeName(string code)
    {
        return code.Split('.')[2] switch
        {
            "1" => "Job_Process_Entity_Not_Found",
            "2" => "Job_Process_Step_Entity_Not_Found",
            "3" => "Redo_Job_Process_Entity_Not_Found",
            "0" or _ => "Entity_Not_Found"
        };
    }

    private static string GetConfigurationCodeName(string code)
    {
        return code.Split('.')[2] switch
        {
            "1" => "Repository_Configuration_Not_Found",
            "2" => "Repository_Entity_Configuration_Not_Found",
            "3" => "EndPoint_Configuration_Not_Found",
            "4" => "Instance_Configuration_Not_Found",
            "5" => "Job_Configuration_Not_Found",
            "6" => "Related_Job_Configuration_Not_Found",
            "7" => "Schedule_Configuration_Not_Found",
            "0" or _ => "Configuration_Not_Found"
        };
    }
}
