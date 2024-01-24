using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Queries.ServiceQueries;
using Baker_DesignPatterns.MediatorPattern.Queries.TestimonialQueries;
using Baker_DesignPatterns.MediatorPattern.Results.ServiceResults;
using Baker_DesignPatterns.MediatorPattern.Results.TestimonialResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.TestimonialHandlers
{
    public class GetAllTestimonialQueryHandler : IRequestHandler<GetAllTestimonialQuery, List<GetAllTestimonialQueryResult>>
    {
        private readonly BakerContext _context;

        public GetAllTestimonialQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllTestimonialQueryResult>> Handle(GetAllTestimonialQuery request, CancellationToken cancellationToken)
        {
            return await _context.Testimonials.Select(x => new GetAllTestimonialQueryResult
            {
                TestimonialID = x.TestimonialID,
                Title = x.Title,
                Comment = x.Comment,
                ImageUrl = x.ImageUrl,
                NameSurname=x.NameSurname,
                Status = x.Status
            }).ToListAsync();
        }
    }
}
