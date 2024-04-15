using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.IO;

public class UniqueUsersFilter : IActionFilter
{
    private static HashSet<string> _uniqueUsers = new HashSet<string>();
    private readonly string _logFile = "UniqueUsersLog.txt";

    public void OnActionExecuting(ActionExecutingContext context)
    {
        string userId = context.HttpContext.Connection.RemoteIpAddress.ToString();
        if (_uniqueUsers.Add(userId))
        {
            File.WriteAllText(_logFile, $"Unique Users Count: {_uniqueUsers.Count}\n");
        }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        // Additional actions after action execution if needed
    }
}
