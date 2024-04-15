using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [ServiceFilter(typeof(LogActionFilter))]
    public IActionResult Index()
    {
        return View();
    }

    [ServiceFilter(typeof(UniqueUsersFilter))]
    public IActionResult Privacy()
    {
        return View();
    }
}
