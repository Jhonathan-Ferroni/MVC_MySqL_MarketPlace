using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
