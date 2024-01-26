using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Commands.StatisticalValuesCommands;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.StatisticalValuesHandlers
{
    public class UpdateStatisticalValuesCommandHandler : IRequestHandler<UpdateStatisticalValuesCommand>
    {
        private readonly BakerContext _context;

        public UpdateStatisticalValuesCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateStatisticalValuesCommand request, CancellationToken cancellationToken)
        {
            var values = _context.StatisticalValues.Find(request.StatisticalValuesID);
            values.Title = request.Title;
            values.Value = request.Value;
            values.Icon = request.Icon;
            await _context.SaveChangesAsync();
        }
    }
}