using Baker_DesignPatterns.MediatorPattern.Results;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Queries
{
    public class GetServiceByIdQuery:IRequest<GetServiceByIdQueryResult>
    {
        public int Id { get; set; }

        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }
    }
}
