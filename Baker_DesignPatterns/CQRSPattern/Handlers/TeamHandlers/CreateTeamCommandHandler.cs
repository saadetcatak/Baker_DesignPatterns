using Baker_DesignPatterns.CQRSPattern.Commands.TeamCommands;
using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.DAL.Entities;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.TeamHandlers
{
    public class CreateTeamCommandHandler
    {
        private readonly BakerContext _context;

        public CreateTeamCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public void Handle(CreateTeamCommand command)
        {
            _context.Teams.Add(new Team
            {
                ImageUrl = command.ImageUrl,
                NameSurname = command.NameSurname,
                Title = command.Title
            });
            _context.SaveChanges();

        }
    }
}
