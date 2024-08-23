using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAppleStore.Class
{
    public class UserObj
    {
        public string userId;
        public string userRoleId;
        public string firstName;
        public string lastName;
        string password;
        public string email;
        public string phoneNo;

        public UserObj(string userId, string userRoleId)
        {
            this.userId = userId;
            this.userRoleId = userRoleId;
        }

        public UserObj(string firstName, string lastName, string email, string phoneNo)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNo = phoneNo;
        }

    }
}