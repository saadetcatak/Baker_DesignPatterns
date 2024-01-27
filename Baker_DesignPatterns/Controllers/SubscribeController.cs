using Baker_DesignPatterns.CQRSPattern.Commands.ProductCommands;
using Baker_DesignPatterns.CQRSPattern.Commands.SubscribeCommands;
using Baker_DesignPatterns.CQRSPattern.Handlers.ProductHandlers;
using Baker_DesignPatterns.CQRSPattern.Handlers.SubscribeHandlers;
using Baker_DesignPatterns.CQRSPattern.Queries.ProductQueries;
using Baker_DesignPatterns.CQRSPattern.Queries.SubscribeQueries;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.Controllers
{
    public class SubscribeController : Controller
    {
        private readonly GetSubscribeByIdQueryHandler _getSubscribeByIdQueryHandler;
        private readonly GetSubscribeQueryHandler _getSubscribeQueryHandler;
        private readonly RemoveSubscribeCommandHandler _removeSubscribeCommandHandler;

        public SubscribeController(GetSubscribeByIdQueryHandler getSubscribeByIdQueryHandler, GetSubscribeQueryHandler getSubscribeQueryHandler, RemoveSubscribeCommandHandler removeSubscribeCommandHandler)
        {
            _getSubscribeByIdQueryHandler = getSubscribeByIdQueryHandler;
            _getSubscribeQueryHandler = getSubscribeQueryHandler;
            _removeSubscribeCommandHandler = removeSubscribeCommandHandler;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DeleteSubscribe(int id)
        {
          _removeSubscribeCommandHandler.Handle(new RemoveSubscribeCommand(id));
            return RedirectToAction("Index");
        }
        public IActionResult DetailSubscribe(int id)
        {
            var values = _getSubscribeByIdQueryHandler.Handle(new GetSubscribeByIdQuery(id));
            return View(values);
        }
    }
}
