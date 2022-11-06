namespace Parsis.Agent.Core.Base;
public interface IObjectIssue
    {
        string Code
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }

        string Message
        {
            get;
            set;
        }
    }
