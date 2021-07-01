using OpenQA.Selenium;

namespace Structura.GuiTests.Selectors
{
    /// <summary>
    /// Selectors from Basic Data form page
    /// </summary>
    class BasicDataFormPageSelectors
    {
        public static readonly By FirstNameInputSelector = By.Id("id_first_name");

        public static readonly By LastNameInputSelector = By.Id("id_last_name");

        public static readonly By EmailInputSelector = By.Id("id_email");

        public static readonly By PhoneInputSelector = By.Id("id_phone");

        public static readonly By PeselInputSelector = By.Id("id_pesel");

        public static readonly By IdNumberInputSelector = By.Id("id_id_numer");

        public static readonly By DateOfBirthInputSelector = By.Id("id_date");

        public static readonly By FormNextButtonSelector = By.Id("form_button_next");
    }
}
