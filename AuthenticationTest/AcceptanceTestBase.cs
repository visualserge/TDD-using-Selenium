using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace WebMain
{
    [SetUpFixture]
    public class AcceptanceTestBase
    {
        public static IWebDriver Driver { get; private set; }
        private IISExpress _iisExpress;

        [SetUp]
        public void SetUp()
        {
            _iisExpress = new IISExpress();
            _iisExpress.Start();

            Driver = LaunchChrome();
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();

            if (_iisExpress != null)
            {
                _iisExpress.Dispose();
            }
        }

        private ChromeDriver LaunchChrome()
        {
            // Disable the remember password popups, and make sure it's full screen so that Bootstrap elements aren't hidden
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            options.AddArgument("--start-maximized");
            ChromeDriver chromeDriver = new ChromeDriver(options);
            chromeDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));

            return chromeDriver;
        }
    }
}
