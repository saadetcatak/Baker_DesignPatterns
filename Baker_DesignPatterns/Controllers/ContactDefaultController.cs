using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.Controllers
{
    public class ContactDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult SendMessagePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessagePartial(Contact contact)
        {
            BakerContext context = new BakerContext();
            context.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
