using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Commands.TestimonialCommands;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.TestimonialHandlers
{
    public class RemoveTestimonialCommandHandler : IRequestHandler<RemoveTestimonialCommand>
    {
        private readonly BakerContext _context;

        public RemoveTestimonialCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveTestimonialCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Testimonials.Find(request.Id);
            _context.Testimonials.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
