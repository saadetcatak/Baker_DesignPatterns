using Baker_DesignPatterns.MediatorPattern.Results.TestimonialResults;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Queries.TestimonialQueries
{
    public class GetTestimonialCountQuery:IRequest<GetTestimonialCountQueryResults>
    {
    }
}
