using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebMain.Core
{
    public class UserLogin
    {
        public Result LogIn(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("admin"))
            {
                return new Result() { issuccess = true, code = 0 };
            }
            else if (username.Equals("") && password.Equals(""))
            {
                return new Result() { issuccess = false, code = 1 };
            }
            else
            {
                return new Result() { issuccess = false, code = 2 };
            }
        }

        public string ShowMessage(Result result)
        {
            string message = string.Empty;

            switch (result.code)
            {
                case 0:
                    message = "Successfully logged in";
                    break;

                case 1 :
                    message = "UserName and Password must be entered";
                    break;

                case 2 :
                    message = "Cannot logged in";
                    break;

                default:
                    break;
            }

            return message;
        }
    }
}
