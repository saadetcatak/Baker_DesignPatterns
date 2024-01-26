using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
