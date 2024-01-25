using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.DAL.Entities;
using Baker_DesignPatterns.MediatorPattern.Commands.TestimonialCommands;
using Baker_DesignPatterns.MediatorPattern.Queries.TestimonialQueries;
using Baker_DesignPatterns.MediatorPattern.Queries.TestimonialQueries;
using Baker_DesignPatterns.MediatorPattern.Results.TestimonialResults;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Baker_DesignPatterns.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly IMediator _mediator;

        public TestimonialController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllTestimonialQuery());
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _mediator.Send(new RemoveTestimonialCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var values = await _mediator.Send(new GetTestimonialByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> TestimonialCount(GetTestimonialCountQuery query)
        {
            var customerCount = await _mediator.Send(query);
            return View(customerCount);
        }

        public IActionResult ChangeHomeStatus(int id)
        {
            var context = new BakerContext();
            var testimonial=context.Testimonials.Where(x=>x.TestimonialID==id).FirstOrDefault();
            if (testimonial.IsHome == true)
            {
                testimonial.IsHome = false;
            }
            else
            {
              testimonial.IsHome = true;
            }
            context.Update(testimonial);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ChangeStatus(int id)
        {
            var context = new BakerContext();
            var testimonial = context.Testimonials.Where(x => x.TestimonialID == id).FirstOrDefault();
            if (testimonial.Status == true)
            {
                testimonial.Status = false;
            }
            else
            {
                testimonial.Status = true;
            }
            context.Update(testimonial);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
