using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripAdvisor_testing
{
    class TestRegister:BaseTest
    {
        [Test]
        public void Register1()
        {
            MainPageAction mainPageAction = new MainPageAction(driver);


            mainPageAction.clickZarejestrujBT();
        }

        [Test]
        public void Register2()
        {
            MainPageAction mainPageAction = new MainPageAction(driver);


            mainPageAction.clickZarejestrujBT();
        }
    }
}
