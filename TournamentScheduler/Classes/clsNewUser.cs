using System;

namespace Classes
{
    public class clsNewUser
    {
        private String Email;
        public string email {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

        private String fName;
        public string firstName {
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
        public string lastName {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }

        private DateTime DOB;
        public DateTime DateOfBirth {
            get
            {
                return DOB;
            }
            set
            {
                DOB = value;
            }
        }

        private long Number;
        public long phoneNumber {
            get
            {
                return Number;
            }
            set
            {
                Number = value;
            }
        }

        private String uID;
        public string userID {
            get
            {
                return uID;
            }
            set
            {
                uID = value;
            }
        }

        private String uPassword;
        public string password {
            get
            {
                return uPassword;
            }
            set
            {
                uPassword = value;
            }
        }
    }
}