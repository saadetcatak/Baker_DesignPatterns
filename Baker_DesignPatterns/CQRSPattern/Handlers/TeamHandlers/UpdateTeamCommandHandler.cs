using Baker_DesignPatterns.CQRSPattern.Commands.ProductCommands;
using Baker_DesignPatterns.CQRSPattern.Commands.TeamCommands;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.TeamHandlers
{
    public class UpdateTeamCommandHandler
    {
        private readonly BakerContext _context;

        public UpdateTeamCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public void Handle(UpdateTeamCommand command)
        {
            var values=_context.Teams.Find(command.TeamID);
            values.Title = command.Title;
            values.NameSurname= command.NameSurname;
            values.ImageUrl = command.ImageUrl;
            _context.SaveChanges();
        }
    }
}
