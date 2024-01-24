using Baker_DesignPatterns.CQRSPattern.Commands.ProductCommands;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.ProductHandlers
{
    public class RemoveProductCommandHandler
    {
        private readonly BakerContext _context;

        public RemoveProductCommandHandler(BakerContext context)
        {
            _context = context;
        }


        public void Handle(RemoveProductCommand command)
        {
            var value = _context.Products.Find(command.Id);
            _context.Products.Remove(value);
            _context.SaveChanges();
        }


    }
}
