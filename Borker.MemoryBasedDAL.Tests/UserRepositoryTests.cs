using System;
using Borker.Model.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Borker.MemoryBasedDAL.Tests
{
    [TestClass]
    public class UserRepositoryTests
    {
        private IUserRepository _userRepository; 

        [TestInitialize]
        public void InitializeAccountRepository()
        {
            _userRepository = new UserRepository();
        }

        [TestMethod]
        public void TestGetFirstId()
        {
            var firstId = _userRepository.getNewID();

            Assert.AreEqual(firstId, 1);
        }

        [TestMethod]
        public void TestAddUser()
        {
            var userAdded = _userRepository.addUser(new Model.User(1, "test@test.t", "testUsername", "testPassword"));
            Assert.IsTrue(userAdded);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestGetUserById()
        {
            _userRepository.addUser(new Model.User(1, "test@test.t", "testUsername", "testPassword"));
            var user = _userRepository.getUserByID(1);

            Assert.IsInstanceOfType(user, typeof(Model.User));
            Assert.AreEqual(user.Username, "testUsername");

            var user2 = _userRepository.getUserByID(2);
        }

        [TestMethod]
        public void TestGetUsernameByUserId()
        {
            _userRepository.addUser(new Model.User(1, "test@test.t", "testUsername", "testPassword"));
            var username = _userRepository.getUsernameByUserId(1);

            Assert.AreEqual(username, "testUsername");
        }

        [TestMethod]
        public void TestGetUserByUsername()
        {
            _userRepository.addUser(new Model.User(1, "test@test.t", "testUsername", "testPassword"));
            var user = _userRepository.getUserByUsername("testUsername");

            Assert.IsInstanceOfType(user, typeof(Model.User));
            Assert.AreEqual(user.Username, "testUsername");
            Assert.AreEqual(user.Id, 1);

            var user2 = _userRepository.getUserByUsername("randomUsername");

            Assert.IsNull(user2);
        }
    }
}
