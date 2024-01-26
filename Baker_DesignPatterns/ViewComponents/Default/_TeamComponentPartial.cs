using Baker_DesignPatterns.CQRSPattern.Handlers.TeamHandlers;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.ViewComponents.Default
{
    public class _TeamComponentPartial:ViewComponent
    {
        private readonly GetTeamQueryHandler _getTeamQueryHandler;

        public _TeamComponentPartial(GetTeamQueryHandler getTeamQueryHandler)
        {
            _getTeamQueryHandler = getTeamQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var values = _getTeamQueryHandler.Handle();
            return View(values);
        }
    }
}
