using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Commands
{
    public class CreateServiceCommand:IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
