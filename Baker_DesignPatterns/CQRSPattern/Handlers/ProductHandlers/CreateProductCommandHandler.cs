using Baker_DesignPatterns.CQRSPattern.Commands.ProductCommands;
using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.DAL.Entities;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly BakerContext _context;

        public CreateProductCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                Description = command.Description,
                Title = command.Title,
                ImageUrl = command.ImageUrl,
                Price = command.Price
            });
            _context.SaveChanges();
        }
    }
}
