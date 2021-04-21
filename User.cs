using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinTownleySoftwareII
{
    class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        //create a new User
        public User(int userID, string userName)
        {
            UserID = userID;
            UserName = userName;
        }
    }
}
