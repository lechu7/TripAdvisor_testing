using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        public void registerNameErrValidate()
        {
            Assert.True(registerNameErr.Displayed);
        }
        public void registerSurnameTXValidate()
        {
            Assert.IsTrue(registerSurnameTX.Displayed);
        }
        public void registerSurnameETSet(String value)
        {
            registerSurnameET.SendKeys(value);
        }
        public void registerSurnameErrValidate()
        {
            Assert.True(registerSurnameErr.Displayed);
        }
        public void registerEmailTXValidate()
        {
            Assert.IsTrue(registerEmailTX.Displayed);
        }
        public void registerEmailETSet(String value)
        {
            registerEmailET.SendKeys(value);
        }
        public void registerEmailErrValidate()
        {
            Assert.True(registerEmailErr.Displayed);
        }
        public void registerPasswordTXValidate()
        {
            Assert.IsTrue(registerPasswordTX.Displayed);
        }
        public void registerPasswordETSet(String value)
        {
            registerPasswordET.SendKeys(value);
        }
        public void registerPasswordErrValidate()
        {
            Assert.True(registerPasswordErr.Displayed);
        }
        public void registerRepeatPasswordTXValidate()
        {
            Assert.IsTrue(registerRepeatPasswordTX.Displayed);
        }
        public void registerRepeatPasswordETSet(String value)
        {
            registerRepeatPasswordET.SendKeys(value);
        }
        public void registerRepeatPasswordErrValidate()
        {
            Assert.True(registerRepeatPasswordErr.Displayed);
        }
        public void registerBTClick()
        {
            registerBT.Click();
        }
        public void positiveRegisterTXValidate()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(positiveRegisterTX.Displayed);
        }
    }
}
