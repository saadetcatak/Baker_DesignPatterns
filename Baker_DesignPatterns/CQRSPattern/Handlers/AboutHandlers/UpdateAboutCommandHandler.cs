using Baker_DesignPatterns.CQRSPattern.Commands.AboutCommands;
using Baker_DesignPatterns.DAL.Context;

namespace Baker_DesignPatterns.CQRSPattern.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly BakerContext _context;

        public UpdateAboutCommandHandler(BakerContext context)
        {
            _context = context;
        }

        public void Handle(UpdateAboutCommand command)
        {
            var values = _context.Abouts.Find(command.AboutID);
            values.Article = command.Article;
            _context.SaveChanges();
        }
    }
}
