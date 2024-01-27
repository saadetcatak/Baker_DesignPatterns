namespace Baker_DesignPatterns.CQRSPattern.Queries.ContactQueries
{
    public class GetContactByIdQuery
    {
        public int Id { get; set; }

        public GetContactByIdQuery(int id)
        {
            Id = id;
        }
    }
}
