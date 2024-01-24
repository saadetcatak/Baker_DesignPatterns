using Baker_DesignPatterns.MediatorPattern.Results.TestimonialResults;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Queries.TestimonialQueries
{
    public class GetAllTestimonialQuery:IRequest<List<GetAllTestimonialQueryResult>>
    {
    }
}
