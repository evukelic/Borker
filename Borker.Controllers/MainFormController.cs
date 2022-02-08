using Borker.Model;
using Borker.Model.Repositories;
using System;
using System.Collections.Generic;

namespace Borker.Controllers
{
    public class MainFormController
    {
        private readonly BorkerController _borkerController;
        private readonly UserController _userController;

        public MainFormController(IBorkerRepository borkerRepository, IUserRepository userRepository)
        {
            _borkerController = new BorkerController(borkerRepository);
            _userController = new UserController(userRepository);

            LoadDefaultModel(borkerRepository, userRepository);
        }

		public void LoadDefaultModel(IBorkerRepository borkerRepository, IUserRepository userRepository)
		{
            userRepository.addUser(new User(userRepository.getNewID(), "admin.test@test.com", "admin", "test"));
            userRepository.addUser(new User(userRepository.getNewID(), "user.test@test.com", "user", "test"));
            borkerRepository.addBorker(new Model.Borker(borkerRepository.getNewID(), "Don", "Samoyed", "Zagreb, Jarun", "25 kn", 1, new DateTime(2022, 5, 22, 8, 0, 0), 1));
            borkerRepository.addBorker(new Model.Borker(borkerRepository.getNewID(), "Cezar", "Mops", "Zagreb, Svetice", "20 kn", 2, new DateTime(2022, 3, 18, 10, 0, 0), 2));
            borkerRepository.addBorker(new Model.Borker(borkerRepository.getNewID(), "Kiki", "Maltezer", "Zagreb, Maksimir", "20 kn", (float)1.5, new DateTime(2022, 1, 23, 11, 30, 0), 2));
        }

        // user calls
        public bool DoesUserExist(string username)
        {
            return _userController.DoesUserExist(username);
        }

        public User GetUserByUsername(string username)
        {
            return _userController.GetUserByUsername(username);
        }

        public void RegisterNewUser(string email, string username, string password)
        {
            _userController.RegisterNewUser(email, username, password);
        }

        public string GetUsernameById(int userId)
        {
            return _userController.GetUsernameById(userId);
        }

        // borker calls
        public List<Model.Borker> GetAvailableBorkers()
        {
            return _borkerController.GetAvailableBorkers();
        }

        public List<Model.Borker> GetAppliedBorkers(int userId)
        {
            return _borkerController.GetAppliedBorkers(userId);
        }

        public List<Model.Borker> GetCreatedBorkers(int userId)
        {
            return _borkerController.GetCreatedBorkers(userId);
        }

        public int AddNewBorker(string name, string breed, string location, string salary, float duration, DateTime date, int userId)
        {
            return _borkerController.AddNewBorker(name, breed, location, salary, duration, date, userId);
        }

        public void AddApplier(int userId, int borkerId)
        {
            _borkerController.AddApplier(borkerId, userId);
        }

        public void UpdateBorker(int borkerId, string name, string breed, string location, string salary, float duration, DateTime date)
        {
            _borkerController.UpdateBorker(borkerId, name, breed, location, salary, duration, date);
        }

        public void DeleteBorker(int borkerId)
        {
            _borkerController.DeleteBorker(borkerId);
        }

        public bool HasBorkerApplier(int borkerId)
        {
            return _borkerController.HasBorkerApplier(borkerId);
        }
    }
}
