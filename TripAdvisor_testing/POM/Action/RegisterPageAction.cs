using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripAdvisor_testing
{
    class RegisterPageAction:RegisterPageView
    {
        IWebDriver driver;
        public RegisterPageAction(IWebDriver driver) : base(driver)
        {

        }
        public void registerTitleTXValidate()
        {
            Assert.IsTrue(registerTitleTX.Displayed);
        }
        public void registerNameTXValidate()
        {
            Assert.IsTrue(registerNameTX.Displayed);
        }
        public void registerNameETSet(String value)
        {
            registerNameET.SendKeys(value);
        }
        public void registerSurnameTXValidate()
        {
            Assert.IsTrue(registerSurnameTX.Displayed);
        }
        public void registerSurnameETSet(String value)
        {
            registerSurnameET.SendKeys(value);
        }
        public void registerEmailTXValidate()
        {
            Assert.IsTrue(registerEmailTX.Displayed);
        }
        public void registerEmailETSet(String value)
        {
            registerEmailET.SendKeys(value);
        }
        public void registerPasswordTXValidate()
        {
            Assert.IsTrue(registerPasswordTX.Displayed);
        }
        public void registerPasswordETSet(String value)
        {
            registerPasswordET.SendKeys(value);
        }
        public void registerRepeatPasswordTXValidate()
        {
            Assert.IsTrue(registerRepeatPasswordTX.Displayed);
        }
        public void registerRepeatPasswordETSet(String value)
        {
            registerRepeatPasswordET.SendKeys(value);
        }
        public void registerBTClick()
        {
            registerBT.Click();
        }
    }
}
