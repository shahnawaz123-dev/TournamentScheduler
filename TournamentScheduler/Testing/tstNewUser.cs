using System;
using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class tstNewUser
    {
       [TestMethod]
       public void Instance()
        {
            clsNewUser newUser = new clsNewUser();
            Assert.IsNotNull(newUser);
        }

        [TestMethod]
        public void firstNameProperty()
        {
            clsNewUser newUser = new clsNewUser();
            String TestData = "Joe";
            newUser.firstName = TestData;
            Assert.AreEqual(newUser.firstName, TestData);
        }
        
        [TestMethod]
        public void lastNameProperty()
        {
            clsNewUser newUser = new clsNewUser();
            String TestData = "Bloggs";
            newUser.lastName = TestData;
            Assert.AreEqual(newUser.lastName, TestData);
        }

        [TestMethod]
        public void DateOfBirth()
        {
            clsNewUser newUser = new clsNewUser();
            DateTime TestData = DateTime.Now.Date;
            newUser.DateOfBirth = TestData;
            Assert.AreEqual(newUser.DateOfBirth, TestData);
        }
       
        [TestMethod]
        public void Email()
        {
            clsNewUser newUser = new clsNewUser();
            String TestData = "joebloggs123@gmail.com";
            newUser.email = TestData;
            Assert.AreEqual(newUser.email, TestData);
        }

        [TestMethod]
        public void PhoneNumber()
        {
            clsNewUser newUser = new clsNewUser();
            Int64 TestData = 07234719231;
            newUser.phoneNumber = TestData;
            Assert.AreEqual(newUser.phoneNumber, TestData);
        }

        [TestMethod]
        public void UserID()
        {
            clsNewUser newUser = new clsNewUser();
            String TestData = "JoeB321";
            newUser.userID = TestData;
            Assert.AreEqual(newUser.userID, TestData);
        }

        [TestMethod]
        public void Password()
        {
            clsNewUser newUser = new clsNewUser();
            String TestData = "BloggsJoe12345";
            newUser.password = TestData;
            Assert.AreEqual(newUser.password, TestData);
            
        }
    }
}
