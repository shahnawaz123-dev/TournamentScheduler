namespace Classes
{
    public class clsTournamentPlayers
    {
        private long Players;
        public long players {
            get
            {
                return Players;
            }
            set
            {
                Players = value;
            }
        }

        private long Teams;
        public long teams {
            get
            {
                return Teams;
            }
            set
            {
                Teams = value;
            }
        }

        private string pName;
        public string playerName {
            get
            {
                return pName;
            }
            set
            {
                pName = value; 
            }
        }

        private string tName;
        public string teamName {
            get
            {
                return tName;
            }
            set
            {
                tName = value;
            }
        }

        private long tID;
        public long teamID {
            get
            {
                return tID;
            }
            set
            {
                tID = value;
            }
        }

        private long pID;
        public long playerID { 
            get
            {
                return pID;
            }
            set
            {
                pID = value;
            }
        }

        public clsTournamentPlayers ThisPlayer { get; set; }

        // public string Valid(string playerName, string teamName, long playerID, long teamID)
        //{

        //}




    }
}