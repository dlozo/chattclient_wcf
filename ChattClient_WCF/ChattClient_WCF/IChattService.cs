using ChattClient_WCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChattClient_WCF
{
    [ServiceContract]
    interface IChattService
    {
        [OperationContract]
        List<Message> GetAll();

        [OperationContract]
        void SendMessage(string message, string userId, string userName, DateTime timeStamp);
    }
}
