using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace UIFrameworkTests.TestBase
{
    public class TestBaseClass
    {
        private string CHROME_BINARY_PATH = @"C:\Git\WorkshopFi\Chromium\chrome.exe";

        // TODO D: Define a new property Driver of IWebDriver type
        public IWebDriver Driver
        {
            get;
            set;
        }

        public IWebDriver InitWebDriver()
        {
            var service = ChromeDriverService.CreateDefaultService();
            var options = new ChromeOptions()
            {
                // TODO A: Create new ChromeOptions with path to the chrome binary     
                
            };

            // TODO K: Custom browser profiles
            // use AddArguments on ChromeOptions "user-data-dir=<path>" to set custom profile path

            // TODO L: Run chrome as headless browser
            // Setup headless browser
            // use AddArguments on ChromeOptions "--headless" to run headless chrome
            // use AddArguments on ChromeOptions "--window-size=1280,1024" to run headless chrome in custom resolution
            
            return new ChromeDriver(service, options);
        }

       
        public void SetUp()
        {
            // TODO C: Create a chrome driver instance before every test with NUnit life cycle
            // Decorate the method with [SetUp] attribute
            // Define a new property Driver of IWebDriver type
            // Init Driver property with InitWebDriver() method
            

            // TODO F2: Set implicit wait for element
            // Use Manage().Timeouts() object on driver
        }

        
        public void TearDown()
        {
            // TODO E: Dispose the web driver instance after every test with NUnit life cycle
            // Decorate the method with [TearDown] attribute
            // Quit and dispose the web driver
            
        }

        // TODO I: Implement a method that takes a screenshot
        // Cast driver to ITakesScreenshot
        // Use method GetScreenshot() to create a ScreenShot
        // Save the screenshot with SaveAsFile method
        public void TakeScreenShot(string fileName)
        {
            // Path where to save the screenshot
            var path = Path.Combine(TestContext.CurrentContext.TestDirectory, fileName + ".png");


            // TODO J: Attach screenshot to NUnit
            // Use method AddTestAttachment on TestContext
        }
    }
}
