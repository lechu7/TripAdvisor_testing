using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TripAdvisor_testing
{
    class BaseTest
    {
        FirefoxDriverService service;

        [SetUp]
        public void beforeTest()
        {
            service = FirefoxDriverService.CreateDefaultService();
            // service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            GlobalVariables.driver = new FirefoxDriver(service);
            GlobalVariables.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);//PRĘDKOŚć SKRYPTU
            GlobalVariables.driver.Navigate().GoToUrl(GlobalVariables.URL);
        }

        [TearDown]
        public void afterTest()
        {
            GlobalVariables.driver.Quit();
        }
    }
}
