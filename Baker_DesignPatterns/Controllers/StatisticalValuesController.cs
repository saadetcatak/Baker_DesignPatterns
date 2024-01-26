using Baker_DesignPatterns.MediatorPattern.Commands. StatisticalValuesCommands;
using Baker_DesignPatterns.MediatorPattern.Queries. StatisticalValuesQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.Controllers
{
    public class StatisticalValuesController : Controller
    {
        private readonly IMediator _mediator;

        public StatisticalValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllStatisticalValuesQuery());
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateStatisticalValues()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateStatisticalValues(CreateStatisticalValuesCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteStatisticalValues(int id)
        {
            await _mediator.Send(new RemoveStatisticalValuesCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateStatisticalValues(int id)
        {
            var values = await _mediator.Send(new GetStatisticalValuesByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStatisticalValues(UpdateStatisticalValuesCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult>  StatisticalValuesCount(GetStatisticalValuesCountQuery query)
        {
            var customerCount = await _mediator.Send(query);
            return View(customerCount);
        }
    }
}
