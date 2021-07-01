using OpenQA.Selenium;

namespace Structura.GuiTests.SeleniumHelpers
{
    public class SeleniumUtils
    {
        private readonly IWebDriver _driver;

        public SeleniumUtils(IWebDriver driver)
        {
            _driver = driver;
        }
        public bool IsElementPresent(By by)
        {
            try
            {
                _driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}

