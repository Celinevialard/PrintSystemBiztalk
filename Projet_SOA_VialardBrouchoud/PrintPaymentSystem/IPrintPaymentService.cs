using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PrintPaymentSystem
{
    [ServiceContract]
    public interface IPrintPaymentService
    {
        [OperationContract]
        QuotaReturn AddChfByCardId(string cardId, decimal chf);
        [OperationContract]
        QuotaReturn AddChfByUsername(string username, decimal chf);
        [OperationContract]
        bool CreateUser(string username, string cardId);
        [OperationContract]
        bool RemoveQuota(string username, int quota);

    }
}
