using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebShop.Logic.Tests
{
    [TestClass]
    public class UnitTestUser
    {
       
        [TestMethod]
        public void Test_GetByEmailAndPassword()
        {
            UserManager manager = new UserManager();
            manager.Seed();
            User user1 = manager.Get(1);
            User user2 = manager.Get(2);
            User user3 = manager.Get(3);


            Assert.AreEqual("antons@gmail.com", user1.Email);
            Assert.AreEqual("12345", user1.Password);
            Assert.AreEqual("anna@gmail.com", user2.Email);
            Assert.AreEqual("12345", user2.Password);
            Assert.AreNotEqual("annna@gmail.com", user2.Email); 
            Assert.AreNotEqual("123456", user2.Password);
            Assert.IsNull(user3);
        }
        [TestMethod]
        public void Test_Create()
        {
            UserManager manager = new UserManager();
            User user = manager.Create(new User()
            {
                Email = "anna@gmail.com",
                Password = "12345"
            });
            Assert.AreEqual("anna@gmail.com", user.Email);
            Assert.AreEqual("12345", user.Password);
            Assert.IsTrue(user.Id > 0);
        }
        [TestMethod]
        public void Test_GetByEmail()
        {
            UserManager manager = new UserManager();
            manager.Seed();
            User user1 = manager.Get(1);
            User user2 = manager.Get(2);
            User user3 = manager.Get(3);

            Assert.AreEqual("antons@gmail.com", user1.Email);
            Assert.AreEqual("anna@gmail.com", user2.Email);
            Assert.IsNull(user3);
        }
        [TestMethod]
        public void Test_Delete()
        {
            UserManager manager = new UserManager();
            manager.Seed();
            manager.Delete(1);

            var allUsers = manager.GetAll();
            var deletedUser = manager.Get(1);

            Assert.AreEqual(1, allUsers.Count);
            Assert.IsNull(deletedUser);
        }
        [TestMethod]
        public void Test_Update()
        {
            UserManager manager = new UserManager();
            manager.Seed();
            manager.Update(new User()
            {
                Id = 2,
                Email = "liga@gmail.com"
            });
            var user = manager.Get(2);
            Assert.AreEqual(2, user.Id);
            Assert.AreEqual("liga@gmail.com", user.Email);
        }
    }
}
//izsaucam ar eksistejoshu epastu un parbaudam vai atgriezh sho lietotaju
            //izsaucam ar neeksistejoshu epastu
            //het by email - meginam gan ar pareizu epastu un nepareizu paroli, otradak un ari ja visi ir nepareizi, vai atgriezh