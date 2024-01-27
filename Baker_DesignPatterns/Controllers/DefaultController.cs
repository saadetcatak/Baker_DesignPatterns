using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult Subscribe()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult Subscribe(Subscribe subscribe)
        {
            BakerContext context = new BakerContext();
            context.Add(subscribe);
            context.SaveChanges();
            return NoContent();

        }
    }
}

