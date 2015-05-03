using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebMain
{
    [TestFixture]
    [Category("Integration")]
    public class LogInIntegrationTest : AcceptanceAbstract
    {
        [Test]
        public void A_User_Can_LogIn_In_Page_Successfully()
        {
            //Arrange
            if (Driver == null) return;
            Driver.Navigate().GoToUrl("http://localhost:16576/LogIn");

            //Act
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("txtUserName")).SendKeys("admin");
            Driver.FindElement(By.Id("txtPassword")).SendKeys("admin");
            Driver.FindElement(By.Id("btnOK")).Click();

            //Assert
            Thread.Sleep(1000);
            Assert.That(Driver.FindElement(By.Id("lblMessage")).Text, Is.EqualTo("Successfully logged in"));
        }

        [Test]
        public void A_User_TriedTo_LogIn_In_Page_But_UnSuccessfully()
        {
            //Arrange
            if (Driver == null) return;
            Driver.Navigate().GoToUrl("http://localhost:16576/LogIn");

            //Act
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("txtUserName")).SendKeys("admin");
            Driver.FindElement(By.Id("txtPassword")).SendKeys("wrongpassword");
            Driver.FindElement(By.Id("btnOK")).Click();

            //Assert
            Thread.Sleep(1000);
            Assert.That(Driver.FindElement(By.Id("lblMessage")).Text, Is.EqualTo("Cannot logged in"));
        }

        [Test]
        public void UserName_and_Password_mustnotbe_emptied()
        {
            //Arrange
            if (Driver == null) return;
            Driver.Navigate().GoToUrl("http://localhost:16576/LogIn");

            //Act
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("txtUserName")).SendKeys("");
            Driver.FindElement(By.Id("txtPassword")).SendKeys("");
            Driver.FindElement(By.Id("btnOK")).Click();

            //Assert
            Thread.Sleep(1000);
            Assert.That(Driver.FindElement(By.Id("lblMessage")).Text, Is.EqualTo("UserName and Password must be entered"));
        }
    }
}
