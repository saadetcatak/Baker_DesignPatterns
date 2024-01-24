namespace Baker_DesignPatterns.CQRSPattern.Commands.ProductCommands
{
    public class UpdateProductCommand
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
