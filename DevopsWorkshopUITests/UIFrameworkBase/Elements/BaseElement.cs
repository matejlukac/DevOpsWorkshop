using OpenQA.Selenium;

namespace UIFrameworkBase.Elements
{

    public class BaseElement
    {
        public IWebElement Element { get; }

        public BaseElement(IWebElement element)
        {
            Element = element;
        }
    }
}
