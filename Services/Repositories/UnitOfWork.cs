using DonateBlood.Models;
using DonateBlood.Services.ServiceInterface;

namespace DonateBlood.Services.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private  AplicationDbContext _context;
        public UnitOfWork(AplicationDbContext context)
        {
            _context = context;
            Donor = new DonorRepository(_context);

        }

        public IDonorRepository Donor{get;set;}

       

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}