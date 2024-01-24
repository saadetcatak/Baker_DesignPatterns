using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Commands.ServiceCommands
{
    public class RemoveServiceCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveServiceCommand(int id)
        {
            Id = id;
        }
    }
}
