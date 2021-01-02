using System;
using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class TournamentParticipants
    {
        [TestMethod]
        public void Instance()
        {
            clsTournamentParticipants tParticitants = new clsTournamentParticipants();
            Assert.IsNotNull(tParticitants);
        }

        //[TestMethod]
        //public void ParticipantsProperty()
        //{
            //clsTournamentParticipants tParticipants = new clsTournamentParticipants();
            //Int64 TestData = 30;
            //tParticipants.participants = TestData;
            //Assert.AreEqual(tParticipants.participants, TestData);
        //}

        [TestMethod]
        public void ParticipantName()
        {
            clsTournamentParticipants tParticipants = new clsTournamentParticipants();
            String TestData = "Manchester United";
            tParticipants.participantName = TestData;
            Assert.AreEqual(tParticipants.participantName, TestData);
        }

        [TestMethod]
        public void ParticipantID()
        {
            clsTournamentParticipants tParticipants = new clsTournamentParticipants();
            Int32 TestData = 2;
            tParticipants.participantID = TestData;
            Assert.AreEqual(tParticipants.participantID, TestData);
        }

        [TestMethod]
        public void ListParticipants()
        {
            clsTournamentParticipants tParticipants = new clsTournamentParticipants();
            List<clsTournamentParticipants> testList = new List<clsTournamentParticipants>();
            clsTournamentParticipants testItem = new clsTournamentParticipants();
            testItem.participantName = "Player 1";
            testItem.participantID = 10;
            testList.Add(testItem);
            tParticipants.ParticipantList = testList;
            Assert.AreEqual(tParticipants.ParticipantList, testList);
 
        }

        [TestMethod]
        public void ListandCount()
        {
            clsTournamentParticipants tParticipants = new clsTournamentParticipants();
            List<clsTournamentParticipants> testList = new List<clsTournamentParticipants>();
            clsTournamentParticipants testItem = new clsTournamentParticipants();
            testItem.participantName = "Player 1";
            testItem.participantID = 49;
            testList.Add(testItem);
            tParticipants.ParticipantList = testList;
            Assert.AreEqual(tParticipants.Count, testList.Count);
        }

        [TestMethod]
        public void Count()
        {
            clsTournamentParticipants tParticipants = new clsTournamentParticipants();
            Int32 count = 0;
            tParticipants.Count = count;
            Assert.AreEqual(tParticipants.Count, count);
        }

        [TestMethod]
        public void ThisParticipant()
        {
            clsTournamentParticipants tParticipants = new clsTournamentParticipants();
            clsTournamentParticipants testParticipant = new clsTournamentParticipants();
            testParticipant.participantName = "Player 1";
            testParticipant.participantID = 50;
            tParticipants.thisParticipant = testParticipant;
            Assert.AreEqual(tParticipants.thisParticipant, testParticipant);
        }

        [TestMethod]
        public void Find()
        {
            clsTournamentParticipants tParticipants = new clsTournamentParticipants();
            Boolean Found = false;
            Boolean OK = true;
            Int32 participantID = 2;
            Found = tParticipants.Find(participantID);
            if(tParticipants.participantID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ParticipantIDFound()
        {
            clsTournamentParticipants tParticipants = new clsTournamentParticipants();
            Boolean found = false;
            Boolean ok = true;
            Int32 participantID = 1;
            found = tParticipants.Find(participantID);
            if(participantID != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void participantNameFound()
        {
            clsTournamentParticipants tParticipants = new clsTournamentParticipants();
            Boolean found = false;
            Boolean ok = true;
            Int32 participantID = 1;
            found = tParticipants.Find(participantID);
            if(tParticipants.participantName != "Player 1")
            {
                ok = false;
            }

            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void AddParticipants()
        {
            clsTournamentParticipants tParticipants = new clsTournamentParticipants();
            clsTournamentParticipants testItem = new clsTournamentParticipants();
            Int32 PrimaryKey = 0;
            testItem.participantName = "Team 1";
            testItem.participantID = 1;
            tParticipants.thisParticipant = testItem;
            PrimaryKey = tParticipants.Add();
            testItem.participantID = PrimaryKey;
            tParticipants.thisParticipant.Find(PrimaryKey);
            Assert.AreEqual(tParticipants.thisParticipant, testItem);

        }

    }
}
