using Baker_DesignPatterns.CQRSPattern.Queries.ProductQueries;
using Baker_DesignPatterns.CQRSPattern.Queries.TeamQueries;
using Baker_DesignPatterns.CQRSPattern.Results.ProductResults;
using Baker_DesignPatterns.CQRSPattern.Results.TeamResults;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.TeamHandlers
{
    public class GetTeamByIdQueryHandler
    {
        private readonly BakerContext _context;

        public GetTeamByIdQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public GetTeamByIdQueryResult Handle(GetTeamByIdQuery query)
        {
            var values = _context.Teams.Find(query.Id);
            return new GetTeamByIdQueryResult
            {
                NameSurname=values.NameSurname,
                Title = values.Title,              
                ImageUrl = values.ImageUrl,
               TeamID = values.TeamID
            };
        }
    }
}
