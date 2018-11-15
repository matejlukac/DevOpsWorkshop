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
            driver.Navigate().GoToUrl(Settings.BaseUrl);
            driver.Quit();
            driver.Dispose();
        }
        
        [Test]
        public void DriverWaitExample()
        {
            var driver = InitWebDriver();

            var page = new LoginPage(driver);
            page.GoTo();
            page.Login();

            // TODO G1: Waiting
            // Sign in
            // Wait for the app to load
            // The page is fully loaded when the Logout button is visible
            // Use method Until on WebDriverWait object

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.IgnoreExceptionTypes(new Type[] { typeof(StaleElementReferenceException) });
            

            // TODO G2: Refactor waiting using ExpectedConditions

            driver.Quit();
            driver.Dispose();
        }
    }
}

