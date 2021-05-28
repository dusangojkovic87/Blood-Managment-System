using System.Collections.Generic;
using DonateBlood.Models;

namespace DonateBlood.Services.ServiceInterface
{
    public interface IDonorRepository
    {
        IEnumerable<AplicationUser> GetAllDonors();
        
    }
}