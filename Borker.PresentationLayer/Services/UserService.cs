using Borker.Controllers;
using Borker.Model;

namespace Borker.PresentationLayer.Services
{
    public class UserService
    {
        private MainFormController _mainController;
        private string _currentUser;

        public UserService(MainFormController controller)
        {
            _mainController = controller;
        }

        public bool DoesUserExist(string username)
        {
            return _mainController.DoesUserExist(username);
        }

        public User GetUserByUsername(string username)
        {
            return _mainController.GetUserByUsername(username);
        }

        public void RegisterNewUser(string email, string username, string password)
        {
           _mainController.RegisterNewUser(email, username, password);
        }

        public bool IsPasswordValid(string username, string password)
        {
            User user = _mainController.GetUserByUsername(username);

            return password.Equals(user.Password);
        }

        public void SetCurrentUser(string username)
        {
            _currentUser = username;
        }

        public string GetCurrentUser()
        {
            return _currentUser;
        }
    }
}
