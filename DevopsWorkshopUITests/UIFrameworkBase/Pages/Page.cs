using OpenQA.Selenium;

namespace UIFrameworkBase.Pages
{
    public class Page
    {
        public IWebDriver Driver { get; }

        public Page(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
