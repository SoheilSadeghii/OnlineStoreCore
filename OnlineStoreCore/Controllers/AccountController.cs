using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using OnlineStoreCore.Data.Repositories;
using OnlineStoreCore.Models;
using System.Security.Claims;

namespace OnlineStoreCore.Controllers
{
    public class AccountController : Controller
    {
        private IUserRepository _userRepository;
        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        #region Register

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
                FullName = register.FullName,
                RegisterDate = DateTime.Now,
                Password = register.Password,
                IsAdmin = false
            };

            _userRepository.AddUser(user);

            return View("SuccessRegister", register);
        }

        #endregion

        #region Login

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            if (!ModelState.IsValid) { return View(login); }

            var user = _userRepository.GetUserForLogin(login.Email.ToLower(), login.Password);

            if (user == null) { ModelState.AddModelError("Email", "اطلاعات صحیح نیست"); return View(login); }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.FullName),
                new Claim(ClaimTypes.Email, user.Email.ToLower()),
                new Claim("IsAdmin", user.IsAdmin.ToString())
            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            var properties = new AuthenticationProperties
            {
                IsPersistent = login.RememberMe
            };

            HttpContext.SignInAsync(principal, properties);

            return Redirect("/");
        }

        #endregion

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/Account/Login");
        }
    }
}
