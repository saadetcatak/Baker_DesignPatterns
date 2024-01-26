using Baker_DesignPatterns.MediatorPattern.Queries.ServiceQueries;
using Baker_DesignPatterns.MediatorPattern.Queries.StatisticalValuesQueries;
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
            var list = await _mediator.Send(new GetAllServiceQuery());
            return View(list);
        }
    }
}
