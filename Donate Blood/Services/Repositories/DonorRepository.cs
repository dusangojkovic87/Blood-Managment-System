using System.Collections.Generic;
using System.Linq;
using DonateBlood.Models;
using DonateBlood.Services.ServiceInterface;
using Microsoft.EntityFrameworkCore;

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

        public AplicationUser GetUserById(int userId){
            return _context.Users.FirstOrDefault(u => u.Id == userId );

        }

        public void SaveProfileImage(AplicationUser model)
        {
           _context.Users.Update(model);
        }

        public Inbox GetUserInbox(int userId){
            
        return  _context.Inbox.SingleOrDefault(i => i.User.Id == userId);

        }
    }
}