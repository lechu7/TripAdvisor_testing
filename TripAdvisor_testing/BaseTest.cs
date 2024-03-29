﻿using System;
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
        protected  IWebDriver driver;
        FirefoxDriverService service;


        [SetUp]
        public void beforeTest()
        {
            FirefoxOptions op = new FirefoxOptions();
            op.SetPreference("geo.enabled", true);
            op.SetPreference("geo.provider.use_corelocation", true);
            op.SetPreference("geo.prompt.testing", true);
            op.SetPreference("geo.prompt.testing.allow", true);
            service = FirefoxDriverService.CreateDefaultService();
            // service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service,op);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);//PRĘDKOŚć SKRYPTU
            driver.Navigate().GoToUrl(GlobalVariables.URL);
        }

        [TearDown]
        public void afterTest()
        {
            driver.Quit();
        }
    }
}
