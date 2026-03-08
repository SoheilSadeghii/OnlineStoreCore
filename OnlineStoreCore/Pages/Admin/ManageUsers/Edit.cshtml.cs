using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineStoreCore.Data;
using OnlineStoreCore.Models;

namespace OnlineStoreCore.Pages.Admin.ManageUsers
{
    public class EditModel : PageModel
    {
        private OnlineStoreCoreContext _context;
        public EditModel(OnlineStoreCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User Users { get; set; }
        public void OnGet(int id)
        {
            Users = _context.Users.Where(u => u.UserId == id)
                .Select(u => new User()
                {
                    UserId = u.UserId,
                    Email = u.Email,
                    FullName = u.FullName,
                    IsAdmin = u.IsAdmin,
                    Password = u.Password,
                    RegisterDate = u.RegisterDate
                }).FirstOrDefault();
        }

        public IActionResult OnPost()
        {
            var user = _context.Users.Find(Users.UserId);

            user.FullName = Users.FullName;
            user.Email = Users.Email;
            user.IsAdmin = Users.IsAdmin;            
            user.Password = Users.Password;
            
            _context.SaveChanges();

            return RedirectToPage ("Index");
        }
    }
}
