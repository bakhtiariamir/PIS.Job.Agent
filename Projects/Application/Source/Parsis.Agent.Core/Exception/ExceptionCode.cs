namespace Parsis.Agent.Core.Exception;
public static class ExceptionCode
{
    public static string ConfigurationNotFoundException = "1000.1.0";
    public static string RepositoryConfigNotFoundException = "1000.1.1";
    public static string RepositoryEntityConfigNotFoundException = "1000.1.2";
    public static string EndPointConfigNotFoundException = "1000.1.3";
    public static string InstanceConfigNotFoundException = "1000.1.4";
    public static string JobConfigNotFoundException = "1000.1.5";
    public static string RelatedJobConfigNotFoundException = "1000.1.6";
    public static string ScheduleConfigNotFoundException = "1000.1.7";

    public static string EntityNotFoundException = "1000.2.0";
    public static string JobProcessEntityNotFoundException = "1000.2.1";
    public static string JobProcessStepEntityNotFoundException = "1000.2.2";
    public static string RedoJobEntityNotFoundException = "1000.2.3";
}
