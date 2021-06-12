using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DonateBlood.Models
{
    public class AplicationDbContext:IdentityDbContext<AplicationUser,AplicationRole, int>
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<AplicationUser> AplicationUser {get;set;}
        public DbSet<Inbox> Inbox {get;set;}

        
    }
}