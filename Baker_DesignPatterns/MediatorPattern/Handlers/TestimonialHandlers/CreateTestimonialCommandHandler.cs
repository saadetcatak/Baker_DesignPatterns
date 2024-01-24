using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.DAL.Entities;
using Baker_DesignPatterns.MediatorPattern.Commands.TestimonialCommands;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
    {
        private readonly BakerContext _context;

        public CreateTestimonialCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
            _context.Testimonials.Add(new Testimonial
            {
                Title = request.Title,
                NameSurname = request.NameSurname,
                ImageUrl = request.ImageUrl,
                Comment = request.Comment,
                Status = request.Status

            });
            _context.SaveChangesAsync();

        }
    }
}
