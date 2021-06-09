using System.Collections.Generic;
using System.Linq;
using DonateBlood.Models;

namespace DonateBlood.Services.ServiceInterface
{
    public interface IDonorRepository
    {
        IEnumerable<AplicationUser> GetAllDonors();
        AplicationUser GetUserById(string userId);
        void SaveProfileImage(AplicationUser model);
        
    }
}