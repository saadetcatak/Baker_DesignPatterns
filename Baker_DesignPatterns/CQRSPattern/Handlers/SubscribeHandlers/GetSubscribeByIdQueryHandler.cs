using Baker_DesignPatterns.CQRSPattern.Queries.ProductQueries;
using Baker_DesignPatterns.CQRSPattern.Queries.SubscribeQueries;
using Baker_DesignPatterns.CQRSPattern.Results.ProductResults;
using Baker_DesignPatterns.CQRSPattern.Results.SubscribeResults;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.SubscribeHandlers
{
    public class GetSubscribeByIdQueryHandler
    {
        private readonly BakerContext _context;

        public GetSubscribeByIdQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public GetSubscribeByIdQueryResult Handle(GetSubscribeByIdQuery query)
        {
            var values = _context.Subscribe.Find(query.Id);
            return new GetSubscribeByIdQueryResult
            {
                SubscribeID = values.SubscribeID,
                Mail=values.Mail

            };
        }
    }
}