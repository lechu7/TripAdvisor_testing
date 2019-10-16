using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace TripAdvisor_testing
{
    class GoogleView
    {
        protected IWebElement inputET = GlobalVariables.driver.FindElement(By.XPath("//*[@name='q']"));
        protected IWebElement szukajWGoogleBT = GlobalVariables.driver.FindElement(By.XPath("//*[@name='btnK']"));
    }
    }

