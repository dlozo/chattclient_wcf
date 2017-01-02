using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ChattClient_WCF.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ChattClientDb")
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Message> Message { get; set; }
    }
}
