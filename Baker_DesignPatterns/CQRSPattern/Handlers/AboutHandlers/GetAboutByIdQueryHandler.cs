using Baker_DesignPatterns.CQRSPattern.Queries.AboutQueries;
using Baker_DesignPatterns.CQRSPattern.Results.AboutResults;
using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.DAL.Entities;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler
    {
        private readonly BakerContext _context;

        public GetAboutByIdQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public GetAboutByIdQueryResult Handle(GetAboutByIdQuery query)
        {
            var values = _context.Abouts.Find(query.Id);
            return new GetAboutByIdQueryResult
            {
                AboutID = values.AboutID,
                Article = values.Article
            };
        }
    }
}
