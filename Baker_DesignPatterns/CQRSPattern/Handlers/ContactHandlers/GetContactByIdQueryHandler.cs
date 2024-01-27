using Baker_DesignPatterns.CQRSPattern.Queries.AboutQueries;
using Baker_DesignPatterns.CQRSPattern.Queries.ContactQueries;
using Baker_DesignPatterns.CQRSPattern.Results.AboutResults;
using Baker_DesignPatterns.CQRSPattern.Results.ContactResults;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly BakerContext _context;

        public GetContactByIdQueryHandler(BakerContext context)
        {
            _context = context;
        }


        public GetContactByIdQueryResult Handle(GetContactByIdQuery query)
        {
            var values = _context.Contacts.Find(query.Id);
            return new GetContactByIdQueryResult
            {
               ContactID=values.ContactID,
               NameSurname=values.NameSurname,
               Email=values.Email,
               Content=values.Content,
               Subject=values.Subject
            };
        }
    }
}
