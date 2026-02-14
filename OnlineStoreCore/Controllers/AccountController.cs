using Microsoft.AspNetCore.Mvc;
using OnlineStoreCore.Data.Repositories;
using OnlineStoreCore.Models;

namespace OnlineStoreCore.Controllers
{
    public class AccountController : Controller
    {
        private IUserRepository _userRepository;
        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
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
