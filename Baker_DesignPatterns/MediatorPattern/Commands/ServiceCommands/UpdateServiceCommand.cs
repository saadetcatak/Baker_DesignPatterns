using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Commands.ServiceCommands
{
    public class UpdateServiceCommand:IRequest
    {
        public int ServiceID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
