using DonateBlood.Models;
using DonateBlood.Services.ServiceInterface;

namespace DonateBlood.Services.Repositories
{
    public class BloodRequestRepository : Repository<BloodRequest>, IBloodRequestRepository
    {
        private AplicationDbContext _context;
        public BloodRequestRepository(AplicationDbContext context) : base(context)
        {
           _context = context;

        }
        public void addBloodRequest(BloodRequest model)
        {
            _context.BloodRequests.Add(model);
        }
    }
}