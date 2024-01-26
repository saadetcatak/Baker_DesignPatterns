using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Queries.StatisticalValuesQueries;
using Baker_DesignPatterns.MediatorPattern.Results.ServiceResults;
using Baker_DesignPatterns.MediatorPattern.Results.StatisticalValuesResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.StatisticalValuesHandlers
{
    public class GetAllStatisticalValuesQueryHandler : IRequestHandler<GetAllStatisticalValuesQuery, List<GetAllStatisticalValuesQueryResult>>
    {
        private readonly BakerContext _context;

        public GetAllStatisticalValuesQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public async  Task<List<GetAllStatisticalValuesQueryResult>> Handle(GetAllStatisticalValuesQuery request, CancellationToken cancellationToken)
        {
            return await _context.StatisticalValues.Select(x => new GetAllStatisticalValuesQueryResult
            {
               StatisticalValuesID = x.StatisticalValuesID,
                Title = x.Title,
                Value = x.Value,
                Icon = x.Icon
            }).ToListAsync();
        }

        
    }
}
