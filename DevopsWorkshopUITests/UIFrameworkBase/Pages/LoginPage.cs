using OpenQA.Selenium;

namespace UIFrameworkBase.Pages
{
    public class LoginPage : Page
    {
        public const string LoginUrl = "file:///C:/Git/WorkshopFrontEnd/DemoReactApp/build/app.html#/login";

        private IWebElement LoginButton => Driver.FindElement(By.XPath("//button[@type='button']"));

        public LoginPage(IWebDriver driver) : base(driver) { }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl(LoginUrl);
        }

        public void Login()
        {
            LoginButton.Click();

            // TODO G3: Better wait after login
            System.Threading.Thread.Sleep(10000);
        }
    }
}
