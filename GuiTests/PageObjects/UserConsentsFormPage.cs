using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Structura.GuiTests.Selectors;
using System;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Structura.GuiTests.PageObjects
{
    /// <summary>
    /// Second page of test form- User Consents
    /// </summary>
    class UserConsentsFormPage
    {
        private readonly IWebDriver _driver;

        public UserConsentsFormPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        /// <summary>
        /// Wait for load page
        /// </summary>
        public void WaitForLoad()
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(3)).Until(ExpectedConditions.ElementExists(UserConsentsFormPageSelectors.FirstConsentsCheckboxSelector));
        }
    }
}
