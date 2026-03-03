using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineStoreCore.Data;
using OnlineStoreCore.Models;

namespace OnlineStoreCore.Pages.Admin
{
    public class EditModel : PageModel
    {
        private OnlineStoreCoreContext _context;
        public EditModel(OnlineStoreCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AddEditProductViewModel Product { get; set; }
        public void OnGet(int id)
        {
            Product = _context.Products.Include(p => p.Item)
                .Where(p => p.Id == id)
                .Select(s => new AddEditProductViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    QuantityInStock = s.Item.QuantityInStock,
                    Price = s.Item.Price
                }).FirstOrDefault();

        }
    }
}
