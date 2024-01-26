using Baker_DesignPatterns.CQRSPattern.Handlers.AboutHandlers;
using Baker_DesignPatterns.CQRSPattern.Handlers.ProductHandlers;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.ViewComponents.Products
{
    public class _ProductListComponentPartial:ViewComponent
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;

        public _ProductListComponentPartial(GetProductQueryHandler getProductQueryHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
        }
        public IViewComponentResult Invoke()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
    }
}
