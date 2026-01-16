using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineStoreCore.Data;
using OnlineStoreCore.Models;

namespace OnlineStoreCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private OnlineStoreCoreContext _context;

        public HomeController(ILogger<HomeController> logger, OnlineStoreCoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();

            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null) return NotFound();

            var categories = _context.Products
                .Where(n => n.Id == id)
                .SelectMany(c => c.CategoryToProducts)
                .Select(ca => ca.Category).ToList();

            return null;
        }

        [Route("/ContactUs")]
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
