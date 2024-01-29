using Microsoft.AspNetCore.Identity;

namespace Baker_DesignPatterns.DAL.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Country { get; set; }
    }
}
