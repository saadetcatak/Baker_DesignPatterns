using Baker_DesignPatterns.CQRSPattern.Commands.AboutCommands;
using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.DAL.Entities;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler
    {
        private readonly BakerContext _context;

        public CreateAboutCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public void Handle(CreateAboutCommand command)
        {
            _context.Abouts.Add(new About
            {
                Article = command.Article
            });
            _context.SaveChanges();
        }
    }
}
