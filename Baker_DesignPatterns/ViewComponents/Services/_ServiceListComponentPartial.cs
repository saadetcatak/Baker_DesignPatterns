using Baker_DesignPatterns.MediatorPattern.Queries.ServiceQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.ViewComponents.Services
{
    public class _ServiceListComponentPartial:ViewComponent
    {
        private readonly IMediator _mediator;

        public _ServiceListComponentPartial(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var  values = await _mediator.Send(new GetAllServiceQuery());
            return View(values);
        }
    }
}
