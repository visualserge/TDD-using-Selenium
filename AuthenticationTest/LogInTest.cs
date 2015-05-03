using NUnit.Framework;
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
            var obj = new UserLogin();

            //Act
            var result = obj.LogIn("admin", "admin");

            //Assert
            Assert.AreEqual(true, result.Issuccess);
        }

        [Test]
        public void Show_SuccessMessage_AfterLogin()
        {
            //Arrange
            var obj = new UserLogin();

            //Act
            var result = obj.LogIn("admin", "admin");
            var message = obj.ShowMessage(result.Code);

            //Assert
            Assert.AreEqual("Successfully logged in", message);
        }

        [Test]
        public void Show_NotSuccessMessage_AfterLogIn()
        {
            //Arrange
            var obj = new UserLogin();

            //Act
            var result = obj.LogIn("admin", "wrongpassword");
            var message = obj.ShowMessage(result.Code);

            //Assert
            Assert.AreEqual("Cannot logged in", message);
        }

        [Test]
        public void Login_Can_ReturnMessageCode()
        {
            //Arrange
            var obj = new UserLogin();

            //Act
            var result = obj.LogIn("", "");
            var message = obj.ShowMessage(result.Code);

            //Assert
            Assert.AreEqual("UserName and Password must be entered", message);
        }

        [Test]
        public void MessageCode_is_Introduce()
        {
            //Arrange
            var obj = new UserLogin();

            //Act
            var result = obj.LogIn("admin", "admin");

            //Assert
            Assert.AreEqual(0, result.Code);
        }
    }
}