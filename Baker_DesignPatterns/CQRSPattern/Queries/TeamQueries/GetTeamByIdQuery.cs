namespace Baker_DesignPatterns.CQRSPattern.Queries.TeamQueries
{
    public class GetTeamByIdQuery
    {
        public int Id { get; set; }

        public GetTeamByIdQuery(int id)
        {
            Id = id;
        }
    }
}
