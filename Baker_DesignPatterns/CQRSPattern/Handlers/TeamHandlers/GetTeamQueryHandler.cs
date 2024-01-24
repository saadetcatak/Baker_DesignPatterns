using Baker_DesignPatterns.CQRSPattern.Results.TeamResults;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.TeamHandlers
{
    public class GetTeamQueryHandler
    {
        private readonly BakerContext _context;

        public GetTeamQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public List<GetTeamQueryResult> Handle()
        {
            var values = _context.Teams.Select(x => new GetTeamQueryResult
            {
                ImageUrl = x.ImageUrl,
                NameSurname = x.NameSurname,
                Title = x.Title,
                TeamID = x.TeamID
            }).ToList();
            return values;
        }
    }
}
