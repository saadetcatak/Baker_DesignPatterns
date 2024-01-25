namespace Baker_DesignPatterns.MediatorPattern.Results.TestimonialResults
{
    public class GetTestimonialByIdQueryResult
    {
        public int TestimonialID { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
    }
}
