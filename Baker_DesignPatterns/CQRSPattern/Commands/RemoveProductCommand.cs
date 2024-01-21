namespace Baker_DesignPatterns.CQRSPattern.Commands
{
    public class RemoveProductCommand
    {
        public int Id { get; set; }

        public RemoveProductCommand(int id)
        {
            Id = id;
        }
    }
}
