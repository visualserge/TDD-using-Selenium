namespace WebMain.Core
{
    public class UserLogin
    {
        public Result LogIn(string username, string password)
        {
            return username.Equals("admin") && password.Equals("admin")
                ? new Result
                {
                    Issuccess = true,
                    Code = MessageCode.Success
                }
                : (username.Equals("") && password.Equals("")
                    ? new Result
                    {
                        Issuccess = false,
                        Code = MessageCode.BlankUserNamePassword
                    }
                    : new Result
                    {
                        Issuccess = false,
                        Code = MessageCode.WrongUserNamePassword
                    });
        }

        public string ShowMessage(MessageCode code)
        {
            switch (code)
            {
                case MessageCode.Success:
                    return "Successfully logged in";
                case MessageCode.BlankUserNamePassword :
                    return "UserName and Password must be entered";
                case MessageCode.WrongUserNamePassword :
                    return "Cannot logged in";
            }

            return null;
        }
    }
}
