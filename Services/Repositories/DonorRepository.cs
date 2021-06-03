using System.Collections.Generic;
using System.Linq;
using DonateBlood.Models;
using DonateBlood.Services.ServiceInterface;

namespace DonateBlood.Services.Repositories
{

    public class DonorRepository : Repository<AplicationUser>, IDonorRepository
    {
        private  AplicationDbContext _context;
        public DonorRepository(AplicationDbContext context):base(context)
        {
           _context = context;

        }

        public IEnumerable<AplicationUser> GetAllDonors()
        {
            return _context.Users.AsQueryable();        
        }

        public AplicationUser GetUserById(string userId){
            return _context.Users.FirstOrDefault(u => u.Id == userId );

        }
    }
}