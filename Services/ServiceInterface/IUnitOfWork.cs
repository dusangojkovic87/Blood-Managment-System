using System;

namespace DonateBlood.Services.ServiceInterface
{
    public interface IUnitOfWork:IDisposable
    {
        IDonorRepository Donor {get;set;}
        IMessageRepository Inbox {get;set;}
        IBloodRequestRepository BloodRequest {get;set;}
        int Save();
         
    }
}