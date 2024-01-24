using Baker_DesignPatterns.CQRSPattern.Commands.AboutCommands;
using Baker_DesignPatterns.CQRSPattern.Commands.TeamCommands;
using Baker_DesignPatterns.CQRSPattern.Handlers.AboutHandlers;
using Baker_DesignPatterns.CQRSPattern.Handlers.TeamHandlers;
using Baker_DesignPatterns.CQRSPattern.Queries.AboutQueries;
using Baker_DesignPatterns.CQRSPattern.Queries.TeamQueries;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.Controllers
{
    public class TeamController : Controller
    {
        private readonly GetTeamQueryHandler _getTeamQueryHandler;
        private readonly CreateTeamCommandHandler _createTeamCommandHandler;
        private readonly GetTeamByIdQueryHandler _getTeamByIdQueryHandler;
        private readonly UpdateTeamCommandHandler _updateTeamCommandHandler;
        private readonly RemoveTeamCommandHandler _removeTeamCommandHandler;

        public TeamController(GetTeamQueryHandler getTeamQueryHandler, CreateTeamCommandHandler createTeamCommandHandler, GetTeamByIdQueryHandler getTeamByIdQueryHandler, UpdateTeamCommandHandler updateTeamCommandHandler, RemoveTeamCommandHandler removeTeamCommandHandler)
        {
            _getTeamQueryHandler = getTeamQueryHandler;
            _createTeamCommandHandler = createTeamCommandHandler;
            _getTeamByIdQueryHandler = getTeamByIdQueryHandler;
            _updateTeamCommandHandler = updateTeamCommandHandler;
            _removeTeamCommandHandler = removeTeamCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getTeamQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTeam(CreateTeamCommand command)
        {
           _createTeamCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTeam(int id)


        {
            var values =_getTeamByIdQueryHandler.Handle(new GetTeamByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateTeam(UpdateTeamCommand command)
        {
           _updateTeamCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTeam(int id)
        {
           _removeTeamCommandHandler.Handle(new RemoveTeamCommand(id));
            return RedirectToAction("Index");
        }
    }
}
