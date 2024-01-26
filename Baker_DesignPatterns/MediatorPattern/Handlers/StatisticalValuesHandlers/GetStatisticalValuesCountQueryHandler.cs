using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Queries.StatisticalValuesQueries;
using Baker_DesignPatterns.MediatorPattern.Results.ServiceResults;
using Baker_DesignPatterns.MediatorPattern.Results.StatisticalValuesResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.StatisticalValuesHandlers
{
    public class GetStatisticalValuesCountQueryHandler : IRequestHandler<GetStatisticalValuesCountQuery, GetStatisticalValuesCountQueryResults>
    {
        private readonly BakerContext _context;

        public GetStatisticalValuesCountQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task<GetStatisticalValuesCountQueryResults> Handle(GetStatisticalValuesCountQuery request, CancellationToken cancellationToken)
        {
            var statisticalValuesCount = await _context.StatisticalValues.CountAsync();
            return new GetStatisticalValuesCountQueryResults
            {
                Count = statisticalValuesCount,
            };
        }
    }
}
