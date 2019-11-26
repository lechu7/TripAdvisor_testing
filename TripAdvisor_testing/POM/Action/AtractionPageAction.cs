﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TripAdvisor_testing
{
    class AtractionPageAction: AtractionPageView
    {
        IWebDriver driver;
        public AtractionPageAction(IWebDriver driver) : base(driver)
        {

        }
        public void nazwaTXValidate()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(nazwaTX.Displayed);
        }
        public void nazwaETSet(String value)
        {
            nazwaET.SendKeys(value);
        }
        public void opisTXValidate()
        {
            Assert.IsTrue(opisTX.Displayed);
        }
        public void opisETSet(String value)
        {
            opisET.SendKeys(value);
        }
        public void imageETSet(String value)
        {
            imageBT.SendKeys(value);
        }
        public void sendBTClick()
        {
            Thread.Sleep(2000);
            sendBT.Click();
            Thread.Sleep(10000);
        }
        public void localizationBTClick()
        {
            localizationBT.Click();
        }

        public void nazwaErrValidate()
        {
            Assert.True(nazwaErr.Displayed);
        }

        //GENERATOR
        public void heightSet(String value)
        {
            heightET.SendKeys(value);
        }
        public void widthSet(String value)
        {
            widthET.SendKeys(value);
        }
    }
}
