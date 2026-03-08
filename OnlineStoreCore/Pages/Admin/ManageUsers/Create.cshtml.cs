using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineStoreCore.Data;
using OnlineStoreCore.Models;

namespace OnlineStoreCore.Pages.Admin.ManageUsers
{
    public class CreateModel : PageModel
    {
        private OnlineStoreCoreContext _context;
        public CreateModel(OnlineStoreCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User Users { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            _context.Users.Add(Users);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
