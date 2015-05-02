using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebMain.Core
{
    public class Result
    {
        public MessageCode code { get; set; }

        public bool issuccess { get; set; }
    }

    public enum MessageCode
    {
        Success = 0,
        WrongUserNamePassword = 1,
        BlankUserNamePassword = 2
    }
}
