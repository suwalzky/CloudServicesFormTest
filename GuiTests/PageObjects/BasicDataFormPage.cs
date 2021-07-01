using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using Structura.GuiTests.Selectors;
using System;

namespace Structura.GuiTests.PageObjects
{
    /// <summary>
    /// First page of test form- Basic Data
    /// </summary>
    class BasicDataFormPage
    {
        private readonly IWebDriver _driver;

        private const string PageUrl = "https://app.bluealert.pl/ba/form/formularz-testowy";

        public BasicDataFormPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public IWebElement FirstNameInput => _driver.FindElement(BasicDataFormPageSelectors.FirstNameInputSelector);

        public IWebElement LastNameInput => _driver.FindElement(BasicDataFormPageSelectors.LastNameInputSelector);

        public IWebElement EmailInput => _driver.FindElement(BasicDataFormPageSelectors.EmailInputSelector);

        public IWebElement PhoneInput => _driver.FindElement(BasicDataFormPageSelectors.PhoneInputSelector);

        public IWebElement PeselInput => _driver.FindElement(BasicDataFormPageSelectors.PeselInputSelector);

        public IWebElement IdNumberInput => _driver.FindElement(BasicDataFormPageSelectors.IdNumberInputSelector);

        public IWebElement DateOfBirthInput => _driver.FindElement(BasicDataFormPageSelectors.DateOfBirthInputSelector);

        public IWebElement FormNextButton => _driver.FindElement(BasicDataFormPageSelectors.FormNextButtonSelector);

        /// <summary>
        /// The open Basic Data form page
        /// </summary>
        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(PageUrl);
            WaitForLoad();
        }

        /// <summary>
        /// Go to next step in form
        /// </summary>
        /// <returns></returns>
        public UserConsentsFormPage GoToNextStepForm()
        {
            FormNextButton.Click();
            var userConsentsFormPage = new UserConsentsFormPage(_driver);
            userConsentsFormPage.WaitForLoad();

            return userConsentsFormPage;
        }

        /// <summary>
        /// Wait for load page
        /// </summary>
        private void WaitForLoad()
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(3)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(BasicDataFormPageSelectors.FirstNameInputSelector));
        }
    }
}
