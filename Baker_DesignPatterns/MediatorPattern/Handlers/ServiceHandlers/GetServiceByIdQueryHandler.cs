﻿using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Queries.ServiceQueries;
using Baker_DesignPatterns.MediatorPattern.Results.ServiceResults;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly BakerContext _context;

        public GetServiceByIdQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Services.FindAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                ServiceID = values.ServiceID,
                Title = values.Title,
                Description = values.Description,
                Icon = values.Icon
            };
        }
    }
}
