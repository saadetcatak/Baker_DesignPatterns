using Baker_DesignPatterns.MediatorPattern.Results.ServiceResults;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Queries.ServiceQueries
{
    public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResult>
    {
        public int Id { get; set; }

        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }
    }
}
