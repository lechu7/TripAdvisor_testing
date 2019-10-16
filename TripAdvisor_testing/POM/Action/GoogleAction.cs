using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace TripAdvisor_testing
{
    class GoogleAction : GoogleView
    {
        public void setInputET(String value)
        {
            inputET.SendKeys(value);
        }
        public void setESC()
        {
            inputET.SendKeys(Keys.Escape);
        }
        public void clickSzukajWGoogleBT()
        {
            szukajWGoogleBT.Click();
        }
    }
}
