using System.Collections.Generic;

namespace Borker.Model.Repositories
{
    public interface IUserRepository
    {
        bool addUser(User user);
        User getUserByID(int userId);
        List<User> getAllUsers();
        User getUserByUsername(string username);
        string getUsernameByUserId(int userId);
        int getNewID();
    }
}
