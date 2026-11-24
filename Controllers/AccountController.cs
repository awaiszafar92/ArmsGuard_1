using Microsoft.AspNetCore.Mvc;

namespace ARMSGUARD.Controllers;

public class AccountController : Controller
{
    public IActionResult Login() => View();

    public IActionResult Signup() => View();
}
