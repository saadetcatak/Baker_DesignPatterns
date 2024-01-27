using Baker_DesignPatterns.CQRSPattern.Commands.ContactCommands;
using Baker_DesignPatterns.CQRSPattern.Commands.ProductCommands;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.ContactHandlers
{
    public class RemoveContactCommandHandler
    {
        private readonly BakerContext _context;

        public RemoveContactCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public void Handle(RemoveContactCommand command)
        {
            var value = _context.Contacts.Find(command.Id);
            _context.Contacts.Remove(value);
            _context.SaveChanges();
        }
    }
}
