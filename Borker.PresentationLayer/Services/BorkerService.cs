using Borker.Controllers;
using Borker.Model;
using System;
using System.Collections.Generic;

namespace Borker.PresentationLayer.Services
{
    public class BorkerService
    {
        private MainFormController _mainController;
        private const string FORMAT = "dd.MM.yyyy hh:mm tt";

        public BorkerService(MainFormController controller)
        {
            _mainController = controller;
        }

        public List<BorkerCardForm> GetAvailableBorkers(string currentUser)
        {
            List<Model.Borker> availableBorkers = _mainController.GetAvailableBorkers();
            List<BorkerCardForm> cards = new List<BorkerCardForm>();

            foreach (Model.Borker borker in availableBorkers)
            {
                string username = _mainController.GetUsernameById(borker.CreatorId);
                cards.Add(new BorkerCardForm(this, currentUser, borker.Id, username, borker.Location, borker.DateTime.ToString(FORMAT), borker.Name, borker.Breed, borker.Duration, borker.Salary));
            }

            return cards;
        }

        public List<BorkerCardForm> GetAppliedBorkers(string username)
        {
            User user = _mainController.GetUserByUsername(username);

            List<Model.Borker> appliedBorkers = _mainController.GetAppliedBorkers(user.Id);
            List<BorkerCardForm> cards = new List<BorkerCardForm>();

            foreach (Model.Borker borker in appliedBorkers)
            {
                string creator = _mainController.GetUsernameById(borker.CreatorId);
                cards.Add(new BorkerCardForm(this, username, borker.Id, creator, borker.Location, borker.DateTime.ToString(FORMAT), borker.Name, borker.Breed, borker.Duration, borker.Salary));
            }

            return cards;
        }

        public List<BorkerCardForm> GetMyBorkers(string username)
        {
            User user = _mainController.GetUserByUsername(username);

            List<Model.Borker> createdBorkers = _mainController.GetCreatedBorkers(user.Id);
            List<BorkerCardForm> cards = new List<BorkerCardForm>();

            foreach (Model.Borker borker in createdBorkers)
            {
                cards.Add(new BorkerCardForm(this, username, borker.Id, username, borker.Location, borker.DateTime.ToString(FORMAT), borker.Name, borker.Breed, borker.Duration, borker.Salary));
            }

            return cards;
        }

        public BorkerCardForm AddBorker(string name, string breed, string location, string salary, float duration, DateTime date, string username)
        {
            User user = _mainController.GetUserByUsername(username);
            

            int borkerId = _mainController.AddNewBorker(name, breed, location, salary, duration, date, user.Id);
            BorkerCardForm newCard = new BorkerCardForm(this, username, borkerId, username, location, date.ToString(FORMAT), name, breed, duration, salary);

            return newCard;

        }

        public void AddApplierToBorker(string username, int borkerId)
        {
            User user = _mainController.GetUserByUsername(username);
            _mainController.AddApplier(user.Id, borkerId);
        }

        public void UpdateBorker(int borkerId, string name, string breed, string location, string salary, float duration, DateTime date)
        {
            _mainController.UpdateBorker(borkerId, name, breed, location, salary, duration, date);
        }

        public void DeleteBorker(int borkerId)
        {
            _mainController.DeleteBorker(borkerId);
        }

        public bool HasBorkerApplier(int borkerId)
        {
            return _mainController.HasBorkerApplier(borkerId);
        }
    }
}
