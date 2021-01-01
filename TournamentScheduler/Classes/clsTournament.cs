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

        public string Valid(string name, string venue)
        {
            String error = "";

            if(name.Length == 0)
            {
                error = error + "Tournament Name has not been filled";
            }

            if(name.Length > 20)
            {
                error = error + "Tournament Name cannot exceed 20 characters";
            }

            if(venue.Length == 0)
            {
                error = error + "Venue has not been filled";
            }

            if (venue.Length > 20)
            {
                error = error + "Venue cannot exceed 20 characters";
            }

            return error;
        }

        
    }
    }

    
    

