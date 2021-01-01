using System;
using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class TournamentPlayers
    {
        [TestMethod]
        public void Instance()
        {
            clsTournamentPlayers tournamentPl = new clsTournamentPlayers();
            Assert.IsNotNull(tournamentPl);
        }

        [TestMethod]
        public void PlayersProperty()
        {
            clsTournamentPlayers tournamentPl = new clsTournamentPlayers();
            Int64 TestData = 20;
            tournamentPl.players = TestData;
            Assert.AreEqual(tournamentPl.players, TestData);

        }

        [TestMethod]
        public void TeamsProperty()
        {
            clsTournamentPlayers tournamentPl = new clsTournamentPlayers();
            Int64 TestData = 20;
            tournamentPl.teams = TestData;
            Assert.AreEqual(tournamentPl.teams, TestData);
        }

        [TestMethod]
        public void PlayerName()
        {
            clsTournamentPlayers tournamentPl = new clsTournamentPlayers();
            String TestData = "Player One";
            tournamentPl.playerName = TestData;
            Assert.AreEqual(tournamentPl.playerName, TestData);
        }

        [TestMethod]
        public void TeamName()
        {
            clsTournamentPlayers tournamentPl = new clsTournamentPlayers();
            String TestData = "Team One";
            tournamentPl.teamName = TestData;
            Assert.AreEqual(tournamentPl.teamName, TestData);
        }

        [TestMethod]
        public void TeamID()
        {
            clsTournamentPlayers tournamentPl = new clsTournamentPlayers();
            Int64 TestData = 1;
            tournamentPl.teamID = TestData;
            Assert.AreEqual(tournamentPl.teamID, TestData);
        }

        [TestMethod]
        public void PlayerID()
        {
            clsTournamentPlayers tournamentPl = new clsTournamentPlayers();
            Int64 TestData = 2;
            tournamentPl.playerID = TestData;
            Assert.AreEqual(tournamentPl.playerID, TestData);
        }

        [TestMethod]
        public void ThisPlayer()
        {
           
            clsTournamentPlayers testPlayer = new clsTournamentPlayers();
            testPlayer.playerName = "player 1";
            testPlayer.teamName = "team 1";
            testPlayer.playerID = 1;
            testPlayer.teamID = 1;
            testPlayer.ThisPlayer = testPlayer;
            Assert.AreEqual(testPlayer.ThisPlayer, testPlayer);

        }

        

       
    }
}
