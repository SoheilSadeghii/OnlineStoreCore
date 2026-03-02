using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineStoreCore.Data;
using OnlineStoreCore.Models;

namespace OnlineStoreCore.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private OnlineStoreCoreContext _context;
        public IndexModel(OnlineStoreCoreContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _context.Products.Include(p => p.Item);
        }
        public void OnPost() { }
    }
}
