using OpenQA.Selenium;

namespace UIFrameworkBase.Pages
{
    public class ItemsPage :Page
    {
        // TODO H2: Implement properties on ItemsPage
        public IWebElement CreateNewButton => Driver.FindElement(By.XPath("//button[contains(text(),'Create new')]"));
        public IWebElement Title => Driver.FindElement(By.Id("title"));
        public IWebElement Description => Driver.FindElement(By.Id(""));
        public IWebElement SubmitButton => Driver.FindElement(By.XPath(""));

        public ItemsPage(IWebDriver driver) : base(driver)
        {
        }

        public void CreateNewItem(string title, string description)
        {
            CreateNewButton.Click();
            Title.SendKeys(title);
            Description.SendKeys(description);
            SubmitButton.Click();
        }
    }
}
