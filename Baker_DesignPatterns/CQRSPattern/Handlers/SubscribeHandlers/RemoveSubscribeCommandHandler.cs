using Baker_DesignPatterns.CQRSPattern.Commands.ProductCommands;
using Baker_DesignPatterns.CQRSPattern.Commands.SubscribeCommands;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.SubscribeHandlers
{
    public class RemoveSubscribeCommandHandler
    {
        private readonly BakerContext _context;

        public RemoveSubscribeCommandHandler(BakerContext context)
        {
            _context = context;
        }
        public void Handle(RemoveSubscribeCommand command)
        {
            var value = _context.Subscribe.Find(command.Id);
            _context.Subscribe.Remove(value);
            _context.SaveChanges();
        }
    }
}
