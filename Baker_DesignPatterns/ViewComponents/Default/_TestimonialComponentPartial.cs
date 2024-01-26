using Baker_DesignPatterns.MediatorPattern.Queries.StatisticalValuesQueries;
using Baker_DesignPatterns.MediatorPattern.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.ViewComponents.Default
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        private readonly IMediator _mediator;

        public _TestimonialComponentPartial(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _mediator.Send(new GetAllTestimonialQuery());
            return View(values);
        }
    }
}
