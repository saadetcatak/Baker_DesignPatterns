using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Commands.TestimonialCommands;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
    {
        private readonly BakerContext _context;

        public UpdateTestimonialCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Testimonials.Find(request.TestimonialID);
            values.Title = request.Title;
            values.NameSurname=request.NameSurname;
            values.Status = request.Status;
            values.Comment = request.Comment;
            values.Status=request.Status;
            values.ImageUrl = request.ImageUrl;
            await _context.SaveChangesAsync();
        }
    }
}
