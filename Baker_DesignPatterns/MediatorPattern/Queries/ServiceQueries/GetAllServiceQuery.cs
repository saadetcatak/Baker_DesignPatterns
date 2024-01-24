using Baker_DesignPatterns.MediatorPattern.Results.ServiceResults;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Queries.ServiceQueries
{
    public class GetAllServiceQuery : IRequest<List<GetAllServiceQueryResult>>
    {
    }
}
