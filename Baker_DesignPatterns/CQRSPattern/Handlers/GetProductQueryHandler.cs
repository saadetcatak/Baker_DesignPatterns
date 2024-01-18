using Baker_DesignPatterns.CQRSPattern.Results;
using Baker_DesignPatterns.DAL.Context;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Baker_DesignPatterns.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly BakerContext _context;

        public GetProductQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ProductID = x.ProductID,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Price = x.Price,
            }).ToList();
            return values;
 

        }
    }
}
