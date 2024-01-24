using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.MediatorPattern.Queries.TestimonialQueries;
using Baker_DesignPatterns.MediatorPattern.Results.ServiceResults;
using Baker_DesignPatterns.MediatorPattern.Results.TestimonialResults;
using MediatR;
using Newtonsoft.Json.Linq;
using NuGet.Protocol.Plugins;

namespace Baker_DesignPatterns.MediatorPattern.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly BakerContext _context;

        public GetTestimonialByIdQueryHandler(BakerContext context)
        {
            _context = context;
        }

        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Testimonials.FindAsync(request.Id);
            return new GetTestimonialByIdQueryResult
            {
                TestimonialID = values.TestimonialID,
                Title = values.Title,
                ImageUrl = values.ImageUrl,
                Comment= values.Comment,
                NameSurname=values.NameSurname,
                Status= values.Status
            };
        }
    }
}
