using Baker_DesignPatterns.CQRSPattern.Results.AboutResults;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly BakerContext _context;

        public GetAboutQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public List<GetAboutQueryResult> Handle()
        {
            var values = _context.Abouts.Select(x => new GetAboutQueryResult
            {
                AboutID = x.AboutID,
                Article = x.Article,
            }).ToList();
            return values;
        }

    }
}
