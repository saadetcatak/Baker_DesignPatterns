using Baker_DesignPatterns.CQRSPattern.Results.ContactResults;
using Baker_DesignPatterns.CQRSPattern.Results.ProductResults;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.ContactHandlers
{
    public class GetContactQueryHandler
    {
        private readonly BakerContext _context;

        public GetContactQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public List<GetContactQueryResult> Handle()
        {
            var values = _context.Contacts.Select(x => new GetContactQueryResult
            {
              ContactID = x.ContactID,
              Subject = x.Subject,
              Content = x.Content,
              NameSurname=x.NameSurname,
              Email = x.Email,
             
            }).ToList();
            return values;


        }
    }
}
