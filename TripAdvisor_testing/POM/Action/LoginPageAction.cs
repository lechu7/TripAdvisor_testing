using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripAdvisor_testing
{
    class LoginPageAction:LoginPageView
    {
        IWebDriver driver;
        public LoginPageAction(IWebDriver driver) : base(driver)
        {

        }
        public void zalogujTitleTXValidate()
        {
            Assert.IsTrue(zalogujTitleTX.Displayed);
        }
        public void emailTXValidate()
        {
            Assert.IsTrue(emailTX.Displayed);
        }
        public void emailETSet(String value)
        {
            emailET.SendKeys(value);
        }
        public void passwordTXValidate()
        {
            Assert.IsTrue(passwordTX.Displayed);
        }
        public void passwordETSet(String value)
        {
            passwordET.SendKeys(value);
        }
        public void saveTXValidate()
        {
            Assert.IsTrue(saveTX.Displayed);
        }
        public void saveCBClick()
        {
            saveCB.Click();
        }
        public void loginBTClick()
        {
            loginBT.Click();
        }
        public void emailErrValidate()
        {
            Assert.True(emailErr.Displayed);
        }
        public void passwordErrValidate()
        {
            Assert.True(passwordErr.Displayed);
        }
        public void positiveLogin()
        {
            emailET.SendKeys(GlobalVariables.emailPositive);
            passwordET.SendKeys(GlobalVariables.passwordPositive);
            loginBT.Click();
        }

    }
}
