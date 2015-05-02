using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebMain.Core
{
    public class UserLogin
    {
        public bool LogIn(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("admin"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ShowMessage(bool result)
        {
            return result ? "Successfully logged in" : "Cannot logged in";
        }
    }
}
