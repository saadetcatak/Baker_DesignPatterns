namespace Baker_DesignPatterns.CQRSPattern.Commands
{
    public class UpdateAboutCommand
    {
        public int AboutID { get; set; }
        public string Article { get; set; }
    }
}
