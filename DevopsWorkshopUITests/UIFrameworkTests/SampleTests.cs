using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UIFrameworkBase.Pages;
using UIFrameworkTests.TestBase;

namespace UIFrameworkTests
{
    public class SampleTest : TestBaseClass
    {
        [Test]
        public void DriverExample()
        {
            // TODO B: Create a simple test
            // Decorate method with [Test] attribute
            // Create an instance of WebDriver
            // Go to the url of your choice using IWebDriver.Navigate()
            // Dispose the driver

            var driver = InitWebDriver();
            driver.Navigate().GoToUrl("http://localhost");
            driver.Quit();
            driver.Dispose();
        }
        
        [Test]
        public void DriverWaitExample()
        {
            var page = new LoginPage(Driver);
            page.GoTo();
            page.Login();

            // TODO G1: Waiting
            // Sign in
            // Wait for the app to load
            // The page is fully loaded when the Logout button is visible

            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.IgnoreExceptionTypes(new Type[] { typeof(StaleElementReferenceException) });

            wait.Until(d =>
            {
                return d.FindElements(By.XPath("//button[contains(text(),'Logout')]")).Count > 0;
            });

            // TODO G2: Refactor waiting using ExpectedConditions
        }
    }
}

