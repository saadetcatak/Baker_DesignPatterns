namespace Baker_DesignPatterns.CQRSPattern.Results.ContactResults
{
    public class GetContactByIdQueryResult
    {
        public int ContactID { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
