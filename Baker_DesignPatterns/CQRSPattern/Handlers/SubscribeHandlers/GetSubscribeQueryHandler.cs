using Baker_DesignPatterns.CQRSPattern.Results.ProductResults;
using Baker_DesignPatterns.CQRSPattern.Results.SubscribeResults;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.SubscribeHandlers
{
    public class GetSubscribeQueryHandler
    {
        private readonly BakerContext _context;

        public GetSubscribeQueryHandler(BakerContext context)
        {
            _context = context;
        }
        public List<GetSubscribeQueryResult> Handle()
        {
            var values = _context.Subscribe.Select(x => new GetSubscribeQueryResult
            {
                SubscribeID = x.SubscribeID,
                Mail = x.Mail
            }).ToList();
            return values;
        }
    }
}
