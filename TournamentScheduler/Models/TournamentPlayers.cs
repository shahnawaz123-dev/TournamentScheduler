using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentScheduler.Models;

namespace TournamentScheduler.Models
{
    public class TournamentPlayers
    {
        private int playerID;
        public int PlayerID {
            get
            {
                return playerID;
            }
            set
            {
                playerID = value;
            }

        }

        private int teamID;
        public int TeamID {
            get
            {
                return teamID;
            }
            set
            {
                teamID = value;
            }
        }

        private String playerName;
        public String PlayerName {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
            }
        }

        private String teamName;
        public String TeamName {
            get
            {
                return teamName;
            }
            set
            {
                teamName = value;
            }
        }

        private int players;
        public int Players {
            get
            {
                return players;
            }
            set
            {
                players = value;
            }
        }

        private int teams;
        public int Teams {
            get
            {
                return teams;
            }
            set
            {
                teams = value;
            }
        }
    }
}
