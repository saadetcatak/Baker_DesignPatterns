using Baker_DesignPatterns.CQRSPattern.Commands;
using Baker_DesignPatterns.CQRSPattern.Handlers;
using Baker_DesignPatterns.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.Controllers
{
    public class AboutController : Controller
    {
        private readonly GetAboutQueryHandler _getAboutQueryHandler;
        private readonly CreateAboutCommandHandler _createAboutCommandHandler;
        private readonly GetAboutByIdQueryHandler _getAboutByIdQueryHandler;
        private readonly UpdateAboutCommandHandler _updateAboutCommandHandler;
        private readonly RemoveAboutCommandHandler _removeAboutCommandHandler;

        public AboutController(GetAboutQueryHandler getAboutQueryHandler, CreateAboutCommandHandler createAboutCommandHandler, GetAboutByIdQueryHandler getAboutByIdQueryHandler, UpdateAboutCommandHandler updateAboutCommandHandler, RemoveAboutCommandHandler removeAboutCommandHandler)
        {
            _getAboutQueryHandler = getAboutQueryHandler;
            _createAboutCommandHandler = createAboutCommandHandler;
            _getAboutByIdQueryHandler = getAboutByIdQueryHandler;
            _updateAboutCommandHandler = updateAboutCommandHandler;
            _removeAboutCommandHandler = removeAboutCommandHandler;
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

        [HttpGet]
        public IActionResult UpdateAbout(int id) 
        
        
        {
            var values=_getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(UpdateAboutCommand command)
        {
            _updateAboutCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAbout(int id)
        {
            _removeAboutCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }
    }
}
