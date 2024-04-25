using DTO;
using System;

namespace BLL
{
    public interface IManager
    {
        QuotaReturn AddChfByCardId(Guid requestId, string cardId, decimal amountChf);
        QuotaReturn AddChfByUsername(Guid requestId, string username, decimal amountChf);
        bool CreateUser(string username, string cardId);
        bool RemoveQuota(string username, int quota);
    }
}