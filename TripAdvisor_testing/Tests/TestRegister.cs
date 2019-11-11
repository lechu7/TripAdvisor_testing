using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TripAdvisor_testing
{
    class TestRegister:BaseTest
    {
        [Test]
        public void Register1()
        {
            //WALIDACJA FORMATKI - Łukaś
            MainPageAction mainPageAction = new MainPageAction(driver);
            RegisterPageAction registerPageAction = new RegisterPageAction(driver);


            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZarejestrujBT();
            registerPageAction.registerTitleTXValidate();
            registerPageAction.registerNameTXValidate();
            registerPageAction.registerNameETSet("name");
            registerPageAction.registerSurnameTXValidate();
            registerPageAction.registerSurnameETSet("surname");
            registerPageAction.registerEmailTXValidate();
            registerPageAction.registerEmailETSet("email");
            registerPageAction.registerPasswordTXValidate();
            registerPageAction.registerPasswordETSet("password");
            registerPageAction.registerRepeatPasswordTXValidate();
            registerPageAction.registerRepeatPasswordETSet("password");
            registerPageAction.registerBTClick();

        }

        [Test]
        public void Register2()
        {
            //REJESTRACJA POPRAWNE DANE - Łukaś
            MainPageAction mainPageAction = new MainPageAction(driver);
            RegisterPageAction registerPageAction = new RegisterPageAction(driver);

            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZarejestrujBT();
            registerPageAction.registerNameETSet(GlobalVariables.registerNameCorrect);
            registerPageAction.registerSurnameETSet(GlobalVariables.registerSurnameCorrect);
            registerPageAction.registerEmailETSet(GlobalVariables.registerEmailCorrect);
            registerPageAction.registerPasswordETSet(GlobalVariables.registerPasswordCorrect);
            registerPageAction.registerRepeatPasswordETSet(GlobalVariables.registerRepeatPasswordCorrect);
            registerPageAction.registerBTClick();
            //ToDo Weryfikacja
        }
    }
}
