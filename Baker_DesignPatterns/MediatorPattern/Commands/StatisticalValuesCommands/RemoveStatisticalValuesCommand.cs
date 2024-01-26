using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Commands.StatisticalValuesCommands
{
    public class RemoveStatisticalValuesCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveStatisticalValuesCommand(int id)
        {
            Id = id;
        }
    }
}
