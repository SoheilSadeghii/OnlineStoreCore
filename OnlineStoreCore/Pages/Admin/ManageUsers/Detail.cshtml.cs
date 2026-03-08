using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineStoreCore.Data;
using OnlineStoreCore.Models;

namespace OnlineStoreCore.Pages.Admin.ManageUsers
{
    public class DetailModel : PageModel
    {
        private OnlineStoreCoreContext _context;
        public DetailModel(OnlineStoreCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User Users { get; set; }
        public void OnGet(int id)
        {
            Users = _context.Users.FirstOrDefault(u => u.UserId == id);
        }
    }
}
