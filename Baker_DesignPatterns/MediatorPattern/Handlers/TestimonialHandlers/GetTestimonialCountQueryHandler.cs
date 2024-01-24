using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Queries.TestimonialQueries;
using Baker_DesignPatterns.MediatorPattern.Results.ServiceResults;
using Baker_DesignPatterns.MediatorPattern.Results.TestimonialResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.TestimonialHandlers
{
    public class GetTestimonialCountQueryHandler : IRequestHandler<GetTestimonialCountQuery, GetTestimonialCountQueryResults>
    {
        private readonly BakerContext _context;

        public GetTestimonialCountQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task<GetTestimonialCountQueryResults> Handle(GetTestimonialCountQuery request, CancellationToken cancellationToken)
        {
            var serviceCount = await _context.Testimonials.CountAsync();
            return new GetTestimonialCountQueryResults
            { 
                Count = serviceCount
            };
        }
    }
}
