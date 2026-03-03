using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineStoreCore.Models;

namespace OnlineStoreCore.Pages.Admin
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public AddEditProductViewModel Product { get; set; }
        public void OnGet()
        {

        }
    }
}
