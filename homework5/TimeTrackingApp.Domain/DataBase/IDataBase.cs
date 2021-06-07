using TimeTrackingApp.Domain.Classes;

namespace TimeTrackingApp.Domain.DataBase
{
    public interface IDataBase<T> where T : User
    {
        void InsertUser(T user);
        User RemoveUser(User removedUser);
        User ActivateAccount(User activatedUser);
        void UpdateUser(T user);
        User CheckUser(string username, string password);

    }
}
