using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripAdvisor_testing
{
    class RegisterPageView
    {
        private IWebDriver driver;
        public RegisterPageView(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[text()='zarejestruj ']")]
        protected IWebElement registerTitleTX;

        [FindsBy(How = How.XPath, Using = "//label[text()='Imię']")]
        protected IWebElement registerNameTX;

        [FindsBy(How = How.Id, Using = "name")]
        protected IWebElement registerNameET;

        [FindsBy(How = How.XPath, Using = "//label[text()='Nazwisko']")]
        protected IWebElement registerSurnameTX;

        [FindsBy(How = How.Id, Using = "surname")]
        protected IWebElement registerSurnameET;

        [FindsBy(How = How.XPath, Using = "//label[text()='E-mail']")]
        protected IWebElement registerEmailTX;

        [FindsBy(How = How.Id, Using = "email")]
        protected IWebElement registerEmailET;

        [FindsBy(How = How.XPath, Using = "//label[text()='Hasło']")]
        protected IWebElement registerPasswordTX;

        [FindsBy(How = How.Id, Using = "password")]
        protected IWebElement registerPasswordET;

        [FindsBy(How = How.XPath, Using = "//label[text()='Powtórz hasło']")]
        protected IWebElement registerRepeatPasswordTX;

        [FindsBy(How = How.Id, Using = "repeatPassword")]
        protected IWebElement registerRepeatPasswordET;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        protected IWebElement registerBT;
    }
}
