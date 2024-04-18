namespace DAL
{
    public interface ISapDB
    {
        string GetUsernameByCardId(string cardId);
        bool CreateUser(string username, string cardId);
    }
}