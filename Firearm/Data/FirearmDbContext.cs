using Firearm.Controllers.Models; // Include the correct namespace here
using Microsoft.EntityFrameworkCore;

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

        public DbSet<Destroyed> Destroyeds { get; set; }

        public DbSet<Civillian> Civillians { get; set; }

        public DbSet<Poag> Poages { get; set; }

        public DbSet<Iofc> iofcs { get; set; }

        public DbSet<Hmts> hmts { get; set; }

        public DbSet<Withdrawal> withdrawals { get; set; }

        public DbSet<FirearmHolders> firearmHolders { get; set; }

        public DbSet<OfficerPending> officerPendings { get; set; }

        public DbSet<User> users { get; set; }

        public DbSet<distructionPending> distructionPendings {get; set;}

        public DbSet<civillianPending>  civillianPendings { get; set;}  
         
        public DbSet<poagPending> poagPendings { get; set; } 

        public DbSet<iofcPending> iofcPendings { get; set; } 

        public DbSet<hmtsPending> hmtsPendings { get; set; } 

        public DbSet<lossPending> losspendings { get; set; } 

        public DbSet<recoverPending> recoverPendings { get; set; } 

        public DbSet<Notification> 
            notifications
        { get; set; }



    }
}
