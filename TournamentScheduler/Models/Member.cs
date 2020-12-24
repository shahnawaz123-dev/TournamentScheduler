using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentScheduler.Models;

namespace TournamentScheduler.Models
{
    public class Member : NewUser
    {
        public String UserID { 
            get
            {
                return userID;
            } 
            set
            {
                userID = value; 
            } 
        }

        public String Password {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

    }
}
