using Borker.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Borker.MemoryBasedDAL
{
    public class BorkerRepository : IBorkerRepository
    {
        private int _nextID = 1;

        private readonly List<Model.Borker> _listBorkers = new List<Model.Borker>();

        public int getNewID()
        {
            int nextID = _nextID;

            _nextID++;

            return nextID;
        }

        public bool addBorker(Model.Borker borker)
        {
            try
            {
                _listBorkers.Add(borker);
                return true;
            } catch
            {
                return false;
            }
        }

        public Model.Borker getBorkerByID(int borkerId)
        {
            var borker = (from b in _listBorkers where b.Id == borkerId select b).First();

            return borker;
        }

        public List<Model.Borker> getAllBorkers()
        {
            return _listBorkers;
        }

        public List<Model.Borker> getAvailableBorkers()
        {
            var borkers = (from b in _listBorkers where b.ApplierId == -1 select b).ToList();

            return borkers;
        }

        public List<Model.Borker> getAppliedBorkers(int userId)
        {
            var borkers = (from b in _listBorkers where b.ApplierId == userId select b).ToList();

            return borkers;
        }

        public List<Model.Borker> getCreatedBorkers(int userId)
        {
            var borkers = (from b in _listBorkers where b.CreatorId == userId select b).ToList();

            return borkers;
        }

        public List<Model.Borker> getBorkersCreatedBy(int userId)
        {
            var borkers = (from b in _listBorkers where b.CreatorId == userId select b).ToList();

            return borkers;
        }

        public List<Model.Borker> getBorkersAppliedBy(int userId)
        {
            var borker = (from b in _listBorkers where b.ApplierId == userId select b).ToList();

            return borker;
        }

        public void setApplier(int applierId, int borkerId)
        {
            var borker = (from b in _listBorkers where b.Id == borkerId select b).First();
            borker.ApplierId = applierId;
        }

        public void updateBorker(int borkerId, string name, string breed, string location, string salary, float duration, DateTime date)
        {
            var borker = getBorkerByID(borkerId);
            borker.Name = name;
            borker.Breed = breed;
            borker.Location = location;
            borker.Salary = salary;
            borker.Duration = duration;
            borker.DateTime = date;
        }

        public void deleteBorker(int borkerId)
        {
            var borker = getBorkerByID(borkerId);
            _listBorkers.Remove(borker);
        }

        public bool hasBorkerApplier(int borkerId)
        {
            var borker = getBorkerByID(borkerId);

            return borker.ApplierId != -1;
        }
    }
}
