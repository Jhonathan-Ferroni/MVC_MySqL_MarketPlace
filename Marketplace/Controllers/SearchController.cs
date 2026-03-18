using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
