using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStoreCore.Data;

namespace OnlineStoreCore.Controllers
{
    public class ProductController : Controller
    {
        private OnlineStoreCoreContext _context;
        public ProductController(OnlineStoreCoreContext context)
        {
            _context = context;
        }

        [Route("Group/{id}/{name}")]
        public IActionResult ShowProductByGroupId(int id, string name)
        {
            ViewData["GroupName"] = name;
            var product = _context.CategoryToProducts
                .Where(c => c.CategoryId == id)
                .Include(c => c.Product)
                .Select(c => c.Product)
                .ToList();

            return View(product);
        }
    }
}
