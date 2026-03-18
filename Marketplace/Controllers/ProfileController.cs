using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
