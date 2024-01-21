using Baker_DesignPatterns.CQRSPattern.Commands;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers
{
    public class RemoveAboutCommandHandler
    {
        private readonly BakerContext _context;

        public RemoveAboutCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public void Handle(RemoveProductCommand command) 
        {
            var value = _context.Abouts.Find(command.Id);
            _context.Abouts.Remove(value);
            _context.SaveChanges();
        }
    }
}
