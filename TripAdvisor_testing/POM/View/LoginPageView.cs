using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripAdvisor_testing
{
    class LoginPageView
    {
        private IWebDriver driver;
        public LoginPageView(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[text()='zaloguj']")]
        protected IWebElement zalogujTitleTX;

        [FindsBy(How = How.XPath, Using = "//label[text()='Email']")]
        protected IWebElement emailTX;

        [FindsBy(How = How.Id, Using = "login")]
        protected IWebElement emailET;

        [FindsBy(How = How.XPath, Using = "//label[text()='Password']")]
        protected IWebElement passwordTX;

        [FindsBy(How = How.Id, Using = "password")]
        protected IWebElement passwordET;

        [FindsBy(How = How.XPath, Using = "//label[text()='zapamiętaj']")]
        protected IWebElement saveTX;

        [FindsBy(How = How.Name, Using = "rememberPassword")]
        protected IWebElement saveCB;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        protected IWebElement loginBT;

    }
}
