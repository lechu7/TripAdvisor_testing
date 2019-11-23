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
    class AtractionPageAction: AtractionPageView
    {
        IWebDriver driver;
        public AtractionPageAction(IWebDriver driver) : base(driver)
        {

        }
        public void nazwaTXValidate()
        {
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
       // public void imageBTClick()
       // {
       //     image2BT.Click();
       // }
        public void imageETSet(String value)
        {
            //imageET.SendKeys(value);
            imageBT.SendKeys(value);
        }
        public void sendBTClick()
        {
            sendBT.Click();
        }
    }
}
