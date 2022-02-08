using Borker.Model.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Borker.MemoryBasedDAL.Tests
{
    [TestClass]
    public class BorkerRepositoryTests
    {
        private IBorkerRepository _borkerRepository;

        [TestInitialize]
        public void InitializeAccountRepository()
        {
            _borkerRepository = new BorkerRepository();
        }

        [TestMethod]
        public void TestGetFirstId()
        {
            var firstId = _borkerRepository.getNewID();

            Assert.AreEqual(firstId, 1);
        }

        [TestMethod]
        public void TestAddBorker()
        {
            var isBorkerAdded = _borkerRepository.addBorker(new Model.Borker(1, "dog", "breed", "zagreb", "25kn", 1, DateTime.Now, 1));

            Assert.IsTrue(isBorkerAdded);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestGetBorkerbyId()
        {
            _borkerRepository.addBorker(new Model.Borker(1, "dog", "breed", "zagreb", "25kn", 1, DateTime.Now, 1));
            var borker = _borkerRepository.getBorkerByID(1);

            Assert.IsInstanceOfType(borker, typeof(Model.Borker));
            Assert.AreEqual(borker.Name, "dog");

            borker = _borkerRepository.getBorkerByID(2);
        }

        [TestMethod]
        public void TestAppliers()
        {
            _borkerRepository.addBorker(new Model.Borker(1, "dog", "breed", "zagreb", "25kn", 1, DateTime.Now, 1));
            var hasApplier = _borkerRepository.hasBorkerApplier(1);

            Assert.IsFalse(hasApplier);

            _borkerRepository.setApplier(1, 1);
            hasApplier = _borkerRepository.hasBorkerApplier(1);

            Assert.IsTrue(hasApplier);
        }

        [TestMethod]
        public void TestUpdateBorker()
        {
            _borkerRepository.addBorker(new Model.Borker(1, "dog", "breed", "zagreb", "25kn", 1, DateTime.Now, 1));
            var borker = _borkerRepository.getBorkerByID(1);

            Assert.AreEqual(borker.Name, "dog");

            _borkerRepository.updateBorker(1, "pupper", "breed", "zagreb", "25kn", 1, DateTime.Now);
            borker = _borkerRepository.getBorkerByID(1);

            Assert.AreEqual(borker.Name, "pupper");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestDeleteBorker()
        {
            _borkerRepository.addBorker(new Model.Borker(1, "dog", "breed", "zagreb", "25kn", 1, DateTime.Now, 1));
            var borker = _borkerRepository.getBorkerByID(1);

            Assert.IsInstanceOfType(borker, typeof(Model.Borker));

            _borkerRepository.deleteBorker(1);

            borker = _borkerRepository.getBorkerByID(1);
        }
    }
}
