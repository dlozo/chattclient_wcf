using ChattClient_WCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattClient_WCF
{
    class ChattService : IChattService
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public List<Message> GetAll()
        {
            List<Message> allMessages = new List<Message>();

            allMessages = context.Message.ToList();
            return allMessages;
        }

        public void SendMessage(string message, string userId, string userName, DateTime timeStamp)
        {
            context.Message.Add(new Message
            {
                MessageText = message,
                UserId = userId,
                UserName = userName,
                TimeStamp = timeStamp
            });
            context.SaveChanges();
        }
    }
}
