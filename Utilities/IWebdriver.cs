using OpenQA.Selenium;

namespace Mars_QA2___Selenium.Utilities
{
    public interface IWebdriver
    {
        IWebElement FindElement(By by);
    }
}