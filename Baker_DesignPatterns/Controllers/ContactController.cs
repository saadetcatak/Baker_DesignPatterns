using Baker_DesignPatterns.CQRSPattern.Commands.ContactCommands;
using Baker_DesignPatterns.CQRSPattern.Handlers.ContactHandlers;
using Baker_DesignPatterns.CQRSPattern.Queries.ContactQueries;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.Controllers
{
    public class ContactController : Controller
    {
        private readonly GetContactByIdQueryHandler _getContactByIdQueryHandler;
        private readonly GetContactQueryHandler _getContactQueryHandler;
        private readonly RemoveContactCommandHandler _removeContactCommandHandler;
        public ContactController(GetContactByIdQueryHandler getContactByIdQueryHandler, GetContactQueryHandler getContactQueryHandler, RemoveContactCommandHandler removeContactCommandHandler)
        {
            _getContactByIdQueryHandler = getContactByIdQueryHandler;
            _getContactQueryHandler = getContactQueryHandler;
            _removeContactCommandHandler = removeContactCommandHandler;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DeleteContact(int id)
        {
            _removeContactCommandHandler.Handle(new RemoveContactCommand(id));
            return RedirectToAction("Index");
        }
        public IActionResult DetailContact(int id)
        {
            var values = _getContactByIdQueryHandler.Handle(new GetContactByIdQuery(id));
            return View(values);
        }
    }
}
