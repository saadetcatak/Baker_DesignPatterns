namespace Baker_DesignPatterns.CQRSPattern.Commands.TeamCommands
{
    public class RemoveTeamCommand
    {
       public int Id { get; set; }

        public RemoveTeamCommand(int id)
        {
            Id = id;
        }
    }
}
