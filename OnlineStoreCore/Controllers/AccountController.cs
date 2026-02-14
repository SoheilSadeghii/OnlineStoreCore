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

            if (_userRepository.IsExistUserByEmail(register.Email.ToLower()))
            {
                ModelState.AddModelError("Email", "ایمیل وارد شده از قبل ثبت نام کرده است.");
                return View(register);
            }

            User user = new User()
            {
                Email = register.Email.ToLower(),
                Password = register.Password,
                IsAdmin = false
            };

            _userRepository.AddUser(user);

            return View("SuccessRegister", register);
        }
    }
}
