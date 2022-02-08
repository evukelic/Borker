using Borker.Model;
using Borker.Model.Repositories;

namespace Borker.Controllers
{
    public class UserController
    {
		private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool DoesUserExist(string username)
        {
            User user = _userRepository.getUserByUsername(username);
            if (user != null)
            {
                return true;
            }

            return false;
        }

        public User GetUserByUsername(string username)
        {
            return _userRepository.getUserByUsername(username);
        }

        public void RegisterNewUser(string email, string username, string password)
        {
            User newUser = new User(_userRepository.getNewID(), email, username, password);

            _userRepository.addUser(newUser);
        }

        public string GetUsernameById(int userId)
        {
            return _userRepository.getUsernameByUserId(userId);
        }
    }
}
