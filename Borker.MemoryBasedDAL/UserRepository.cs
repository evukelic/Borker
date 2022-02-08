using Borker.Model;
using Borker.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Borker.MemoryBasedDAL
{
    public class UserRepository : IUserRepository
    {
        private int _nextID = 1;

        private readonly List<User> _listUsers = new List<User>();

        public int getNewID()
        {
            int nextID = _nextID;

            _nextID++;

            return nextID;
        }

        public bool addUser(User user)
        {
            try
            {
                _listUsers.Add(user);

                return true;
            } catch
            {
                return false;
            }
                
        }

        public List<User> getAllUsers()
        {
            return _listUsers;
        }

        public User getUserByID(int userId)
        {
            var user = (from u in _listUsers where u.Id == userId select u).First();

            return user;
        }

        public User getUserByUsername(string username)
        {
            User user;

            try
            {
                user = (from u in _listUsers where u.Username == username select u).First();
            } catch (InvalidOperationException)
            {
                user = null;
            }
            

            return user;
        }

        public string getUsernameByUserId(int id)
        {
            var user = (from u in _listUsers where u.Id == id select u).First();

            return user.Username;
        }
    }
}
