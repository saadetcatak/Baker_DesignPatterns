namespace Baker_DesignPatterns.CQRSPattern.Commands.TeamCommands
{
    public class UpdateTeamCommand
    {
        public int TeamID { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
