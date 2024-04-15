using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

public class LogActionFilter : IActionFilter
{
    private readonly string _logFile = "ActionLog.txt";

    public void OnActionExecuting(ActionExecutingContext context)
    {
        string actionName = context.ActionDescriptor.RouteValues["action"];
        string controllerName = context.ActionDescriptor.RouteValues["controller"];
        string logText = $"Controller: {controllerName}, Method: {actionName}, Time: {DateTime.Now}\n";
        File.AppendAllText(_logFile, logText);
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        // Additional logging after action execution if needed
    }
}
