using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentScheduler.Models
{
    public class NewUser
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public string email { get; set; }
        public char phoneNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public String userID { get; set; }


    }
}
