using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Commands.TestimonialCommands
{
    public class RemoveTestimonialCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveTestimonialCommand(int id)
        {
            Id = id;
        }
    }
}
