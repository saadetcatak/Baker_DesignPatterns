using Baker_DesignPatterns.CQRSPattern.Commands.TeamCommands;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.TeamHandlers
{
    public class RemoveTeamCommandHandler
    {
        private readonly BakerContext _context;

        public RemoveTeamCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public void Handle(RemoveTeamCommand command) 
        {
            var value=_context.Teams.Find(command.Id);
            _context.Teams.Remove(value);
            _context.SaveChanges();
        }
    }
}
