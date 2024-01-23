using Baker_DesignPatterns.MediatorPattern.Results;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Queries
{
    public class GetAllServiceQuery:IRequest<List<GetAllServiceQueryResult>>
    {
    }
}
