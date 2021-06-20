using System.Collections.Generic;
using System.Linq;
using DonateBlood.Models;

namespace DonateBlood.Services.ServiceInterface
{
    public interface IBloodRequestRepository
    {
         void addBloodRequest(BloodRequest model);
         ICollection<BloodRequestShowModel> getBloodRequests();
         BloodRequestShowModel getBloodRequestById(int Id);
         ICollection<BloodRequestShowModel> GetBloodRequestsByUserId(int Id);
         void deletePost(int Id);
        
    }
}