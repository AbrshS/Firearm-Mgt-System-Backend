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
    }
}
  