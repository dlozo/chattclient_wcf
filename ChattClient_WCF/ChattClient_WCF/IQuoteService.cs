using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChattClient_WCF
{
    [ServiceContract]
    interface IQuoteService
    {
        [OperationContract]
        string Get();
    }
}
