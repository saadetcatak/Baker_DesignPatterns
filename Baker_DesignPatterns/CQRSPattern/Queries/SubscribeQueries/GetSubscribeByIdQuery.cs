namespace Baker_DesignPatterns.CQRSPattern.Queries.SubscribeQueries
{
    public class GetSubscribeByIdQuery
    {
        public int Id { get; set; }

        public GetSubscribeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
