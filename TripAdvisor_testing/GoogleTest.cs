using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TripAdvisor_testing
{
    class GoogleTest : BaseTest
    {
        [Test]
        public void googleTest1()
        {

            GoogleAction googleAction = new GoogleAction();


            googleAction.setInputET("WZIM");
            googleAction.setESC();
            googleAction.clickSzukajWGoogleBT();
        }
    }
}
