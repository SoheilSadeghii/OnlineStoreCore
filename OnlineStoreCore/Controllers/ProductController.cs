using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
