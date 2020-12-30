using System;
using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class tstTournament
    {
        [TestMethod]
        public void StartDateProperty()
        {
            clsTournament tournament = new clsTournament();
            DateTime TestData = DateTime.Now.Date;
            tournament.StartDate = TestData;
            Assert.AreEqual(tournament.StartDate, TestData);
        }

        [TestMethod]
        public void EndDateProperty()
        {
            clsTournament tournament = new clsTournament();
            DateTime TestData = DateTime.Now.Date;
            tournament.EndDate = TestData;
            Assert.AreEqual(tournament.EndDate, TestData);
        }

        [TestMethod]
        public void TournamentNameProperty()
        {
            clsTournament tournament = new clsTournament();
            String TestData = "Football Tournament";
            tournament.Name = TestData;
            Assert.AreEqual(tournament.Name, TestData);
        }

        [TestMethod]
        public void VenueProperty()
        {
            clsTournament tournament = new clsTournament();
            String TestData = "King Power Stadium";
            tournament.Venue = TestData;
            Assert.AreEqual(tournament.Venue, TestData);
        }

        [TestMethod]
        public void TournamentTypeProperty()
        {
            clsTournament tournament = new clsTournament();
            String TestData = "RoundRobin";
            tournament.TournamentType = TestData;
            Assert.AreEqual(tournament.TournamentType, TestData);
        }

       

        
    }
}
