namespace Baker_DesignPatterns.CQRSPattern.Queries.ProductQueries
{
    public class GetProductByIdQuery
    {
        public GetProductByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
