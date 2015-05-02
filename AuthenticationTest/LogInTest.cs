using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using WebMain.Core;

namespace WebMain
{
    [TestFixture]
    [Category("Unit")]
    public class LogInTest
    {
        [Test]
        public void A_User_Can_LogIn_Successfully()
        {
            //Arrange
            UserLogin obj = new UserLogin();
            Result result = new Result();

            //Act
            result = obj.LogIn("admin", "admin");

            //Assert
            Assert.AreEqual(true, result.issuccess);
        }

        [Test]
        public void Show_SuccessMessage_AfterLogin()
        { 
            //Arrange
            UserLogin obj = new UserLogin();
            Result result = new Result();
            string _message = string.Empty;

            //Act
            result = obj.LogIn("admin", "admin");
            _message = obj.ShowMessage(result.code);

            //Assert
            Assert.AreEqual("Successfully logged in", _message);
        }

        [Test]
        public void Show_NotSuccessMessage_AfterLogIn()
        { 
            //Arrange
            UserLogin obj = new UserLogin();
            Result result = new Result();
            string _message = string.Empty;

            //Act
            result = obj.LogIn("admin","wrongpassword");
            _message = obj.ShowMessage(result.code);

            //Assert
            Assert.AreEqual("Cannot logged in", _message);
        }

        [Test]
        public void Login_Can_ReturnMessageCode()
        {
            //Arrange
            UserLogin obj = new UserLogin();
            Result result = new Result();
            string _message = string.Empty;
           
            //Act
            result = obj.LogIn("","");
            _message = obj.ShowMessage(result.code);

            //Assert
            Assert.AreEqual("UserName and Password must be entered", _message);
        }

        [Test]
        public void MessageCode_is_Introduce()
        { 
            //Arrange
            UserLogin obj = new UserLogin();
            Result result = new Result();

            //Act
            result = obj.LogIn("admin","admin");

            //Assert
            Assert.AreEqual(MessageCode.Success, result.code);
        }
    }
}
