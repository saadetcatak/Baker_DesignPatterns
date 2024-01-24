using Baker_DesignPatterns.CQRSPattern.Commands.AboutCommands;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.AboutHandlers
{
    public class RemoveAboutCommandHandler
    {
        private readonly BakerContext _context;

        public RemoveAboutCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public void Handle(RemoveAboutCommand command)
        {
            var value = _context.Abouts.Find(command.Id);
            _context.Abouts.Remove(value);
            _context.SaveChanges();
        }
       
    }
}
