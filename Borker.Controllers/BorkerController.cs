using Borker.Model.Repositories;
using System;
using System.Collections.Generic;

namespace Borker.Controllers
{
    class BorkerController
    {
        private readonly IBorkerRepository _borkerRepository;

        public BorkerController(IBorkerRepository borkerRepository)
        {
            _borkerRepository = borkerRepository;
        }

        public List<Model.Borker> GetAvailableBorkers()
        {
            return _borkerRepository.getAvailableBorkers();
        }

        public int AddNewBorker(string name, string breed, string location, string salary, float duration, DateTime date, int userId)
        {
            Model.Borker newBorker = new Model.Borker(_borkerRepository.getNewID(), name, breed, location, salary, duration, date, userId);

            _borkerRepository.addBorker(newBorker);

            return newBorker.Id;
        }

        public List<Model.Borker> GetAppliedBorkers(int userId)
        {
            return _borkerRepository.getAppliedBorkers(userId);
        }

        public List<Model.Borker> GetCreatedBorkers(int userId)
        {
            return _borkerRepository.getCreatedBorkers(userId);
        }

        public void AddApplier(int userId, int borkerId)
        {
            _borkerRepository.setApplier(borkerId, userId);
        }

        public void UpdateBorker(int borkerId, string name, string breed, string location, string salary, float duration, DateTime date)
        {
            _borkerRepository.updateBorker(borkerId, name, breed, location, salary, duration, date);
        }

        public void DeleteBorker(int borkerId)
        {
            _borkerRepository.deleteBorker(borkerId);
        }

        public bool HasBorkerApplier(int borkerId)
        {
            return _borkerRepository.hasBorkerApplier(borkerId);
        }

    }
}
