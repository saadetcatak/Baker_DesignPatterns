using Baker_DesignPatterns.CQRSPattern.Commands.ProductCommands;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly BakerContext _context;

        public UpdateProductCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.Title = command.Title;
            values.Description = command.Description;
            values.Price = command.Price;
            _context.SaveChanges();
        }
    }
}
