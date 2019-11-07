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
    }
}
