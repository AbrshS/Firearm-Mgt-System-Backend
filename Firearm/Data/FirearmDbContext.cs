using Microsoft.EntityFrameworkCore;
using Firearm.Controllers.Models; // Include the correct namespace here

namespace Firearm.Data
{
    public class FirearmDbContext : DbContext
    {
        public FirearmDbContext(DbContextOptions<FirearmDbContext> options) : base(options)
        {
        }

        // Define DbSet for your entity (use the fully qualified name)
        public DbSet<Firearm.Controllers.Models.Firearm> Firearms { get; set; }
        public DbSet<Officer> Officers { get; set; } 

        public DbSet<Loss> Losses { get; set; } 

        public DbSet<Destroyed> Destroyeds {  get; set; }

        public DbSet<Civillian> Civillians { get; set; }
         
        public DbSet<Poag> Poages { get; set; } 
        
        public DbSet<Iofc> iofcs { get; set; }   

        public DbSet<Hmts> hmts { get; set; } 

    }
}
  