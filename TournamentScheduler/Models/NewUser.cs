using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentScheduler.Models
{
    public class NewUser
    {
        private String fName;
        public String firstName {
            get
            {
                return fName;
            }
            set 
            {
                fName = value;
            } 
        }

        private String lName;
        public String lastName {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }

        private String Email;
        public String email {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

        private Char number;
        public Char phoneNumber {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        private DateTime DOB;
        public DateTime dateOfBirth {
            get
            {
                return DOB;
            }
            set
            {
                DOB = value;
            }
        }

        private String ID;
        public String userID {
            get
            {
                return ID;
            } 
            set
            {
                ID = value;
            }
        }

        private String Password;
        public String password {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }


    }
}
