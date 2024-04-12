using DTO;

namespace BLL
{
    public interface IManager
    {
        QuotaReturn AddChfByCardId(string cardId, decimal amountChf);
        QuotaReturn AddChfByUsername(string username, decimal amountChf);
       
    }
}