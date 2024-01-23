using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Queries;
using Baker_DesignPatterns.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Baker_DesignPatterns.MediatorPattern.Handlers
{
    public class GetServiceCountQueryHandler : IRequestHandler<GetServiceCountQuery, GetServiceCountQueryResults>
    {
        private readonly BakerContext _context;

        public GetServiceCountQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task<GetServiceCountQueryResults> Handle(GetServiceCountQuery request, CancellationToken cancellationToken)
        {
            var serviceCount = await _context.Services.CountAsync();
            return new GetServiceCountQueryResults
            {
                Count = serviceCount,
            };
        }
    }
}
