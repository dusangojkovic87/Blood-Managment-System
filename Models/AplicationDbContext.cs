using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DonateBlood.Models
{
    public class AplicationDbContext:IdentityDbContext<AplicationUser,IdentityRole, string>
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {
            
        }

        DbSet<AplicationUser> AplicationUser {get;set;}
        
    }
}