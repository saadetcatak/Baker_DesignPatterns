using Baker_DesignPatterns.CQRSPattern.Commands;
using Baker_DesignPatterns.CQRSPattern.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.Controllers
{
    public class AboutController : Controller
    {
        private readonly GetAboutQueryHandler _getAboutQueryHandler;
        private readonly CreateAboutCommandHandler _createAboutCommandHandler;

        public AboutController(GetAboutQueryHandler getAboutQueryHandler, CreateAboutCommandHandler createAboutCommandHandler)
        {
            _getAboutQueryHandler = getAboutQueryHandler;
            _createAboutCommandHandler = createAboutCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getAboutQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAbout() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutCommand command)
        {
            _createAboutCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
