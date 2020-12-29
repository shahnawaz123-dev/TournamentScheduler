using System;
using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing
{
    [TestClass]
    public class tstMember
    {
        [TestMethod]
        public void Instance()
        {
            clsMember member = new clsMember();
            Assert.IsNotNull(member);
        }

        [TestMethod]
        public void memberIDProperty()
        {
            clsMember member = new clsMember();
            String TestData = "UserID123";
            member.ID = TestData;
            Assert.AreEqual(member.ID, TestData);

        }

        [TestMethod]
        public void memberPasswordProperty()
        {
            clsMember member = new clsMember();
            String TestData = "Password12345";
            member.password = TestData;
            Assert.AreEqual(member.password, TestData);
        }





    }


}
