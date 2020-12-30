using Classes;

namespace Classes
{
    public class clsMember
    {
        private string uID;
        public string ID {
            get
            {
                return uID;
            }
            set
            {
                uID = value;
            }
        }

        private string uPassword;
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