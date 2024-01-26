using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Queries.StatisticalValuesQueries;
using Baker_DesignPatterns.MediatorPattern.Results.ServiceResults;
using Baker_DesignPatterns.MediatorPattern.Results.StatisticalValuesResults;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.StatisticalValuesHandlers
{
    public class GetStatisticalValuesByIdQueryHandler : IRequestHandler<GetStatisticalValuesByIdQuery, GetStatisticalValuesByIdQueryResult>
    {
        private readonly BakerContext _context;

        public GetStatisticalValuesByIdQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task<GetStatisticalValuesByIdQueryResult> Handle(GetStatisticalValuesByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.StatisticalValues.FindAsync(request.Id);
            return new GetStatisticalValuesByIdQueryResult
            {
                StatisticalValuesID=values.StatisticalValuesID,
                Title = values.Title,
               Value = values.Value,
                Icon = values.Icon
            };
        }
    }
}
