using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.DAL.Entities;
using Baker_DesignPatterns.MediatorPattern.Commands.StatisticalValuesCommands;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.StatisticalValuesHandlers
{
    public class CreateStatisticalValuesCommandHandler : IRequestHandler<CreateStatisticalValuesCommand>
    {
        private readonly BakerContext _context;

        public CreateStatisticalValuesCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateStatisticalValuesCommand request, CancellationToken cancellationToken)
        {

            _context.StatisticalValues.Add(new StatisticalValues
            {
                Title = request.Title,
                Value = request.Value,
                Icon = request.Icon
            });
            await _context.SaveChangesAsync();
        }
    }
}
