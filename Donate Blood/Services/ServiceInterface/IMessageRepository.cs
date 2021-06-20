using DonateBlood.Models;

namespace DonateBlood.Services.ServiceInterface
{
    public interface IMessageRepository
    {
        void addMessageToInbox(Inbox model);
        
    }
}