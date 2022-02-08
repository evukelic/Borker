using System;
using System.Collections.Generic;

namespace Borker.Model.Repositories
{
    public interface IBorkerRepository
    {
        bool addBorker(Borker borker);
        Borker getBorkerByID(int borkerId);
        List<Borker> getAllBorkers();
        List<Borker> getAppliedBorkers(int userId);
        List<Borker> getCreatedBorkers(int userId);
        List<Borker> getBorkersCreatedBy(int userId);
        List<Borker> getBorkersAppliedBy(int userId);
        List<Borker> getAvailableBorkers();
        int getNewID();
        void setApplier(int borkerId, int applierId);
        void updateBorker(int borkerId, string name, string breed, string location, string salary, float duration, DateTime date);
        void deleteBorker(int borkerId);
        bool hasBorkerApplier(int borkerId);
    }
}
