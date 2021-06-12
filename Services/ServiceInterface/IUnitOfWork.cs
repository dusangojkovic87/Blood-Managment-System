using System;

namespace DonateBlood.Services.ServiceInterface
{
    public interface IUnitOfWork:IDisposable
    {
        IDonorRepository Donor {get;set;}
        IMessageRepository Inbox {get;set;}
        int Save();
         
    }
}