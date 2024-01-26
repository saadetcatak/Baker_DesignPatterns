using Baker_DesignPatterns.MediatorPattern.Queries.StatisticalValuesQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.ViewComponents.Default
{
    public class _StatisticalComponentPartial:ViewComponent
    {
        private readonly IMediator _mediator;

        public _StatisticalComponentPartial(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var list = await _mediator.Send(new GetAllStatisticalValuesQuery());
            return View(list);
        }
    }
}
