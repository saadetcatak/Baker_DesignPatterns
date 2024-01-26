using Baker_DesignPatterns.MediatorPattern.Results.StatisticalValuesResults;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Queries.StatisticalValuesQueries
{
    public class GetStatisticalValuesCountQuery:IRequest<GetStatisticalValuesCountQueryResults>
    {
    }
}
