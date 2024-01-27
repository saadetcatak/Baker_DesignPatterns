namespace Baker_DesignPatterns.CQRSPattern.Commands.SubscribeCommands
{
    public class RemoveSubscribeCommand
    {
        public int Id { get; set; }

        public RemoveSubscribeCommand(int id)
        {
            Id = id;
        }
    }
}
