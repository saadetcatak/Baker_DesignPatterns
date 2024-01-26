using Baker_DesignPatterns.CQRSPattern.Handlers.AboutHandlers;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.ViewComponents.About
{
    public class _AboutUsComponentPartial:ViewComponent
    {
        private readonly GetAboutQueryHandler _getAboutQueryHandler;

        public _AboutUsComponentPartial(GetAboutQueryHandler getAboutQueryHandler)
        {
            _getAboutQueryHandler = getAboutQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var values = _getAboutQueryHandler.Handle();
            return View(values);
        }
    }
}
