using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineStoreCore.Data;
using OnlineStoreCore.Models;

namespace OnlineStoreCore.Pages.Admin.ManageUsers
{
    public class DeleteModel : PageModel
    {
        private OnlineStoreCoreContext _context;
        public DeleteModel(OnlineStoreCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User Users { get; set; }
        public void OnGet(int id)
        {
            Users = _context.Users.FirstOrDefault(u => u.UserId == id);
        }
        public IActionResult OnPost()
        {
            var user = _context.Users.Find(Users.UserId);

            _context.Remove(user);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
