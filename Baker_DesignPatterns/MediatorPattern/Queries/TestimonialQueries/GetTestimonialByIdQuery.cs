using Baker_DesignPatterns.MediatorPattern.Results.TestimonialResults;
using MediatR;

namespace Baker_DesignPatterns.MediatorPattern.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery:IRequest<GetTestimonialByIdQueryResult>
    {
        public int Id { get; set; }

        public GetTestimonialByIdQuery(int id)
        {
            Id = id;
        }
    }
}
