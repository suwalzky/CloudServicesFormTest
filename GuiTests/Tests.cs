using System;
using System.Text;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using Structura.GuiTests.PageObjects;
using Structura.GuiTests.SeleniumHelpers;

namespace Structura.GuiTests
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver _driver;
        private StringBuilder _verificationErrors;

        [SetUp]
        public void SetupTest()
        {
            _driver = new DriverFactory().Create();
            _verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                _driver.Quit();
                _driver.Close();
            }
            catch (Exception)
            {
                // Ignore errors if we are unable to close the browser
            }
            _verificationErrors.ToString().Should().BeEmpty("No verification errors are expected.");
        }

        [Test]
        public void FillBasicDataFormAndGoToNextStep()
        {
            //Test data
            const string firstName = "Sebastian";
            const string lastName = "Suwalski";
            const string dateOfBirth = "1996-04-21";
            const string email = "suwalski.sj@gmail.com";
            const int phoneNumber = 518786997;
            const long peselNumber = 83030870157;
            const string idNumber = "OPS546855";

            var basicDataFormPage = new BasicDataFormPage(_driver);
            basicDataFormPage.OpenPage();
            FillBasicDataForm();
            basicDataFormPage.GoToNextStepForm();

            Assert.IsTrue(new SeleniumUtils(_driver).IsElementPresent(Selectors.UserConsentsFormPageSelectors.FirstConsentsCheckboxSelector), 
                "The test correctly completed fields in step 1 of the form and successfully proceeded to step 2.");
            
            void FillBasicDataForm()
            {
                basicDataFormPage.DateOfBirthInput.SendKeys(dateOfBirth);
                basicDataFormPage.FirstNameInput.SendKeys(firstName);
                basicDataFormPage.LastNameInput.SendKeys(lastName);
                basicDataFormPage.EmailInput.SendKeys(email);
                basicDataFormPage.PhoneInput.SendKeys(phoneNumber.ToString());
                basicDataFormPage.PeselInput.SendKeys(peselNumber.ToString());
                basicDataFormPage.IdNumberInput.SendKeys(idNumber);
            }
        }
    }
}


