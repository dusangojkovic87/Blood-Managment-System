using System;
using DonateBlood.Models;
using DonateBlood.Services.ServiceInterface;
using Microsoft.EntityFrameworkCore;

namespace DonateBlood.Services.Repositories
{
    public class MessageRepository :Repository<Inbox>, IMessageRepository
    {
       
        private  AplicationDbContext _context;
        public MessageRepository(AplicationDbContext context):base(context)
        {
           _context = context;

        }
        public void addMessageToInbox(Inbox model)
        {
        
           _context.Inbox.Add(model);
        
        }
    }
}