using NUnit.Framework;
using OpenQA.Selenium;

namespace WebMain
{
    /// <summary>
    ///     Create a abstract class in order to prevent duplicated creation of chrome object that will result to double
    ///     browser.
    /// </summary>
    public abstract class AcceptanceAbstract
    {
        protected IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = AcceptanceTestBase.Driver;
        }
    }
}