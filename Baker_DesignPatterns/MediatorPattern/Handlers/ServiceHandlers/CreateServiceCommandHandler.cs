using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.DAL.Entities;
using Baker_DesignPatterns.MediatorPattern.Commands.ServiceCommands;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.ServiceHandlers
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
    {
        private readonly BakerContext _context;

        public CreateServiceCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            _context.Services.Add(new Service
            {
                Title = request.Title,
                Description = request.Description,
                Icon = request.Icon
            });
            await _context.SaveChangesAsync();
        }
    }
}
