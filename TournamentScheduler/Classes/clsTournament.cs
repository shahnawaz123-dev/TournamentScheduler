using System;
using Classes;

namespace Classes
{
    public class clsTournament
    {
        private DateTime sDate;
        public DateTime StartDate {
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
        public DateTime EndDate {
            get
            {
                return eDate;
            }
            set
            {
                eDate = value;
            }
        }

        private String name;
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private String venue;
        public string Venue {
            get
            {
                return venue;
            }
            set
            {
                venue = value;
            }
        }

        private String tournamentType;
        public string TournamentType {
            get
            {
                return tournamentType;
            }
            set
            {
                tournamentType = value;
            }
        }

        
    }
    }

    
    

