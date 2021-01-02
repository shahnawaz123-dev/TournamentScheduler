using System;
using System.Collections.Generic;

namespace Classes
{
    public class clsTournamentParticipants
    {

        List<clsTournamentParticipants> pList = new List<clsTournamentParticipants>();
        clsTournamentParticipants thisP = new clsTournamentParticipants();

        //public short participants { get; set; }

        private string pName;
        public string participantName {
            get
            {
                return pName;
            }
            set
            {
                pName = value;
            }
        }

        private Int32 pID;
        public Int32 participantID {
            get
            {
                return pID;
            }
            set
            {
                pID = value;
            }
        }

        public List<clsTournamentParticipants> ParticipantList {
            get
            {
                return pList;
            }
            set
            {
                pList = value;
            }
        }
        public int Count {
            get
            {
                return pList.Count;
            }
            set { 
            }
        }
        public clsTournamentParticipants thisParticipant {
            get
            {
                return thisP;
            }
            set
            {
                thisP = value;
            }
        }

        public bool Find(int participantID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ParticipantID", participantID);
            DB.Execute("filterByParticipantID");
            if(DB.Count == 1)
            {
                pID = Convert.ToInt32(DB.DataTable.Rows[0]["ParticipantID"]);
                pName = Convert.ToString(DB.DataTable.Rows[0]["ParticipantName"]);
                return true;
            }
            else
            {
                return false;
            }



            
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ParticipantName", thisP.participantName);
            return DB.Execute("InsertParticipants");
        }
    }
}