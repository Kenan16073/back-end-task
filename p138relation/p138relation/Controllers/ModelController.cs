using Microsoft.AspNetCore.Mvc;

namespace p138relation.Controllers
{
    public class ModelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
