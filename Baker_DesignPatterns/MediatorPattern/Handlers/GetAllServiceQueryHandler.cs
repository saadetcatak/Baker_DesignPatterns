using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Queries;
using Baker_DesignPatterns.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace Baker_DesignPatterns.MediatorPattern.Handlers
{
    public class GetAllServiceQueryHandler : IRequestHandler<GetAllServiceQuery, List<GetAllServiceQueryResult>>
    {
        private readonly BakerContext _context;

        public GetAllServiceQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllServiceQueryResult>> Handle(GetAllServiceQuery request, CancellationToken cancellationToken)
        {
            return await _context.Services.Select(x=>new GetAllServiceQueryResult
            {
                ServiceID = x.ServiceID,
                Title = x.Title,
                Description = x.Description,
                Icon = x.Icon
            }).ToListAsync();
        }
    }
}

