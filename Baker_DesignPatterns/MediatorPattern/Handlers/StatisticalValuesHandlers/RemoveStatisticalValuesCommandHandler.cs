using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Commands.StatisticalValuesCommands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.StatisticalValuesHandlers
{
    public class RemoveStatisticalValuesCommandHandler : IRequestHandler<RemoveStatisticalValuesCommand>
    {
        private readonly BakerContext _context;

        public RemoveStatisticalValuesCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveStatisticalValuesCommand request, CancellationToken cancellationToken)
        {
            var values = _context.StatisticalValues.Find(request.Id);
            _context.StatisticalValues.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
