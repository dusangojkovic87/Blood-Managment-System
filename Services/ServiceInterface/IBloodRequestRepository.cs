using DonateBlood.Models;

namespace DonateBlood.Services.ServiceInterface
{
    public interface IBloodRequestRepository
    {
         void addBloodRequest(BloodRequest model);
    }
}