using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Commands.ServiceCommands;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.ServiceHandlers
{
    public class RemoveServiceCommandHandler : IRequestHandler<RemoveServiceCommand>
    {
        private readonly BakerContext _context;

        public RemoveServiceCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveServiceCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Services.Find(request.Id);
            _context.Services.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
