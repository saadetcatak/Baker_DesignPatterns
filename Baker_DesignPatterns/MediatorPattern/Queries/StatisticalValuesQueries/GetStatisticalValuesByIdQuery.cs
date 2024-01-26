using Baker_DesignPatterns.MediatorPattern.Results.ServiceResults;
using Baker_DesignPatterns.MediatorPattern.Results.StatisticalValuesResults;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Queries.StatisticalValuesQueries
{
    public class GetStatisticalValuesByIdQuery:IRequest<GetStatisticalValuesByIdQueryResult>
    {
        public int Id { get; set; }

        public GetStatisticalValuesByIdQuery(int id)
        {
            Id = id;
        }
    }
}
