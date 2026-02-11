using Microsoft.AspNetCore.Mvc;

namespace OnlineStoreCore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
