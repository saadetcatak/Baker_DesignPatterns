using Baker_DesignPatterns.CQRSPattern.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.Controllers
{
    public class AboutController : Controller
    {
        private readonly GetAboutQueryHandler _getAboutQueryHandler;

        public AboutController(GetAboutQueryHandler getAboutQueryHandler)
        {
            _getAboutQueryHandler = getAboutQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getAboutQueryHandler.Handle();
            return View(values);
        }
    }
}
