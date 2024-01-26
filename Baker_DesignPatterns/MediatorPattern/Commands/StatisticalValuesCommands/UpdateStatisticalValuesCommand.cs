using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Commands.StatisticalValuesCommands
{
    public class UpdateStatisticalValuesCommand:IRequest
    {
        public int StatisticalValuesID { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public string Icon { get; set; }
    }
}
