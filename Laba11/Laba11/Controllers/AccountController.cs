using Microsoft.AspNetCore.Mvc;

[Route("account")]
public class AccountController : Controller
{
    [Route("login")] 
    public IActionResult Login()
    {
        return View();
    }

    [Route("register")] 
    public IActionResult Register()
    {
        return View();
    }
}
