using Baker_DesignPatterns.CQRSPattern.Queries.ProductQueries;
using Baker_DesignPatterns.CQRSPattern.Results.ProductResults;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly BakerContext _context;

        public GetProductByIdQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductByIdQueryResult
            {
                Title = values.Title,
                Description = values.Description,
                Price = values.Price,
                ImageUrl = values.ImageUrl,
                ProductID = values.ProductID
            };
        }
    }
}
