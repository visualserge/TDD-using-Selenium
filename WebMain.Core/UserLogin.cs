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
                return new Result() 
                { 
                    issuccess = true, 
                    code = MessageCode.Success 
                };
            }
            else if (username.Equals("") && password.Equals(""))
            {
                return new Result() 
                {                  
                    issuccess = false, 
                    code = MessageCode.BlankUserNamePassword 
                };
            }
            else
            {
                return new Result() 
                { 
                    issuccess = false, 
                    code = MessageCode.WrongUserNamePassword 
                };
            }
        }

        public string ShowMessage(MessageCode code)
        {
            string message = string.Empty;

            switch (code)
            {
                case MessageCode.Success:
                    message = "Successfully logged in";
                    break;

                case MessageCode.BlankUserNamePassword :
                    message = "UserName and Password must be entered";
                    break;

                case MessageCode.WrongUserNamePassword :
                    message = "Cannot logged in";
                    break;

                default:
                    break;
            }

            return message;
        }
    }
}
