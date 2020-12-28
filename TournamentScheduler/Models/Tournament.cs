using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentScheduler.Models;

namespace TournamentScheduler.Models
{
    public class Tournament
    {
        private DateTime sDate;
        public DateTime startDate {
            get
            {
                return sDate;
            }
            set
            {
                sDate = value;
            }
        }

        private DateTime eDate;
        public DateTime endDate { 
            get
            {
                return eDate;
            }
            set
            {
                eDate = value;
            }
        }


        private String tournamentName;
        public String TournamentName {
            get
            {
                return tournamentName;
            }
            set
            {
                tournamentName = value;
            }
        }

        private String venue;
        public String Venue {
            get
            {
                return venue;
            }
            set
            {
                venue = value;
            }
        }


    }
}
