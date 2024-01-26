using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.ViewComponents.Default
{
    public class _DefaultMainComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}
