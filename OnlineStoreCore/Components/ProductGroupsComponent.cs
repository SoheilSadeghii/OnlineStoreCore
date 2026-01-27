using Microsoft.AspNetCore.Mvc;
using OnlineStoreCore.Data;

namespace OnlineStoreCore.Components
{
    public class ProductGroupsComponent : ViewComponent
    {
        private OnlineStoreCoreContext _context;

        public ProductGroupsComponent(OnlineStoreCoreContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_context.Categories);
        }
    }
}
