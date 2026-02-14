using Microsoft.AspNetCore.Mvc;
using OnlineStoreCore.Models;

namespace OnlineStoreCore.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid) { return View(register); }

            return View();
        }
    }
}
