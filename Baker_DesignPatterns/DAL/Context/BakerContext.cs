using Baker_DesignPatterns.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Baker_DesignPatterns.DAL.Context
{
    public class BakerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SAADET\\SQLEXPRESS01; initial catalog=DbBakerDesignPatterns;integrated security=true;trusted_connection=true;encrypt=false");          
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<StatisticalValues> StatisticalValues { get; set;}
        public DbSet<Subscribe> Subscribe { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        
    }
}
