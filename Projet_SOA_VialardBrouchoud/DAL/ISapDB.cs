namespace DAL
{
    public interface ISapDB
    {
        string GetUsernameByCardId(string cardId);
        bool CreateUser(string username, string cardId);
        bool RemoveQuota(string username, int quota);
        bool AddQuota(string username, int quota);
    }
}