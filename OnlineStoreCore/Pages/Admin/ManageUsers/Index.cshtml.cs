using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineStoreCore.Data;
using OnlineStoreCore.Models;

namespace OnlineStoreCore.Pages.Admin.ManageUsers
{
    public class IndexModel : PageModel
    {
        private OnlineStoreCoreContext _context;
        public IndexModel(OnlineStoreCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IEnumerable<User> Users { get; set; }
        public void OnGet()
        {
            Users = _context.Users.ToList();
        }
    }
}
