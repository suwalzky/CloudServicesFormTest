using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Structura.GuiTests.SeleniumHelpers
{
    //Specflow:
    //[Binding]
    public class SeleniumHelper
    {
        private static IWebDriver _driver;

        public static void ResetDriver()
        {
            try
            {
                if (_driver != null)
                {
                    Driver.Close();
                    Driver.Quit();
                    _driver = null;
                }
            }
            catch (Exception) { }
        }
        public static IWebDriver Driver
        {
            get
            {
                if (_driver != null)
                {
                    return _driver;
                }
                _driver = new DriverFactory().Create();
                // Avoid synchronization issues by applying timed delay to each step if necessary
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes((5));
                _driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(5);
                return _driver;
            }
        }
    }
}
