using NUnit.Framework;
using UIFrameworkBase.Pages;
using UIFrameworkTests.TestBase;

namespace UIFrameworkTests.Items
{
    public class ItemsTests : TestBaseClass
    {
        [SetUp]
        public void Login()
        {
            var page = new LoginPage(Driver);
            page.GoTo();

            page.Login();
        }


        [Test]
        public void ItemIsCreated()
        {
            var page = new ItemsPage(Driver);
            // TODO H1: Implement properties on ItemsPage
            // Uncomment the test
            // page.CreateNewItem("title", "description");
        }
    }
}
