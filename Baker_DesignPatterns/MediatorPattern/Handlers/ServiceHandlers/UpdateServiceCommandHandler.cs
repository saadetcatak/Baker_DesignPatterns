using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Commands.ServiceCommands;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.ServiceHandlers
{

    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly BakerContext _context;

        public UpdateServiceCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Services.Find(request.ServiceID);
            values.Title = request.Title;
            values.Description = request.Description;
            values.Icon = request.Icon;
            await _context.SaveChangesAsync();

        }
    }
}
