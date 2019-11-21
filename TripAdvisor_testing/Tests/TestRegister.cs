using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TripAdvisor_testing
{
    class TestRegister : BaseTest
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
            //REJESTRACJA POPRAWNE DANE + LOGOWANIE NA NOWE KONTO - Łukaś
            MainPageAction mainPageAction = new MainPageAction(driver);
            RegisterPageAction registerPageAction = new RegisterPageAction(driver);
            LoginPageAction loginPageAction = new LoginPageAction(driver);

            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZarejestrujBT();
            registerPageAction.registerNameETSet(GlobalVariables.registerNameCorrect);
            registerPageAction.registerSurnameETSet(GlobalVariables.registerSurnameCorrect);
            registerPageAction.registerEmailETSet(GlobalVariables.registerEmailCorrect);
            registerPageAction.registerPasswordETSet(GlobalVariables.registerPasswordCorrect);
            registerPageAction.registerRepeatPasswordETSet(GlobalVariables.registerPasswordCorrect);
            registerPageAction.registerBTClick();
            registerPageAction.positiveRegisterTXValidate();
            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZalogujBT();
            loginPageAction.emailETSet(GlobalVariables.registerEmailCorrect);
            loginPageAction.passwordETSet(GlobalVariables.registerPasswordCorrect);
            loginPageAction.loginBTClick();
            loginPageAction.positiveLoginTXValidate();
        }

        [Test]
        public void Register3()
        {
            //REJESTRACJA niepoprawny e-mail - Łukaś
            MainPageAction mainPageAction = new MainPageAction(driver);
            RegisterPageAction registerPageAction = new RegisterPageAction(driver);

            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZarejestrujBT();
            registerPageAction.registerNameETSet(GlobalVariables.registerNameCorrect);
            registerPageAction.registerSurnameETSet(GlobalVariables.registerSurnameCorrect);
            registerPageAction.registerEmailETSet(GlobalVariables.registerEmailIncorrect);
            registerPageAction.registerPasswordETSet(GlobalVariables.registerPasswordCorrect);
            registerPageAction.registerRepeatPasswordETSet(GlobalVariables.registerPasswordCorrect);
            registerPageAction.registerBTClick();
        }

        [Test]
        public void Register4()
        {
            //REJESTRACJA hasło bez wielkiej litery i cyfry - Łukaś
            MainPageAction mainPageAction = new MainPageAction(driver);
            RegisterPageAction registerPageAction = new RegisterPageAction(driver);

            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZarejestrujBT();
            registerPageAction.registerNameETSet(GlobalVariables.registerNameCorrect);
            registerPageAction.registerSurnameETSet(GlobalVariables.registerSurnameCorrect);
            registerPageAction.registerEmailETSet(GlobalVariables.registerEmailCorrect);
            registerPageAction.registerPasswordETSet(GlobalVariables.registerPasswordIncorrect1);
            registerPageAction.registerRepeatPasswordETSet(GlobalVariables.registerPasswordIncorrect1);
            registerPageAction.registerBTClick();
            registerPageAction.registerPasswordErrValidate();
        }

        [Test]
        public void Register5()
        {
            //REJESTRACJA hasło za krótkie - Łukaś
            MainPageAction mainPageAction = new MainPageAction(driver);
            RegisterPageAction registerPageAction = new RegisterPageAction(driver);

            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZarejestrujBT();
            registerPageAction.registerNameETSet(GlobalVariables.registerNameCorrect);
            registerPageAction.registerSurnameETSet(GlobalVariables.registerSurnameCorrect);
            registerPageAction.registerEmailETSet(GlobalVariables.registerEmailCorrect);
            registerPageAction.registerPasswordETSet(GlobalVariables.registerPasswordIncorrect2);
            registerPageAction.registerRepeatPasswordETSet(GlobalVariables.registerPasswordIncorrect2);
            registerPageAction.registerBTClick();
            registerPageAction.registerPasswordErrValidate();
        }

        [Test]
        public void Register6()
        {
            //REJESTRACJA zle powtórzone hasło - Łukaś
            MainPageAction mainPageAction = new MainPageAction(driver);
            RegisterPageAction registerPageAction = new RegisterPageAction(driver);

            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZarejestrujBT();
            registerPageAction.registerNameETSet(GlobalVariables.registerNameCorrect);
            registerPageAction.registerSurnameETSet(GlobalVariables.registerSurnameCorrect);
            registerPageAction.registerEmailETSet(GlobalVariables.registerEmailCorrect);
            registerPageAction.registerPasswordETSet(GlobalVariables.registerPasswordCorrect);
            registerPageAction.registerRepeatPasswordETSet(GlobalVariables.registerPasswordIncorrect1);
            registerPageAction.registerBTClick();
            registerPageAction.registerRepeatPasswordErrValidate();
        }

        [Test]
        public void Register7()
        {
            //REJESTRACJA brak imienia i nazwiska - Łukaś
            MainPageAction mainPageAction = new MainPageAction(driver);
            RegisterPageAction registerPageAction = new RegisterPageAction(driver);

            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZarejestrujBT();
            registerPageAction.registerEmailETSet(GlobalVariables.registerEmailCorrect);
            registerPageAction.registerPasswordETSet(GlobalVariables.registerPasswordCorrect);
            registerPageAction.registerRepeatPasswordETSet(GlobalVariables.registerPasswordCorrect);
            registerPageAction.registerBTClick();
            registerPageAction.registerNameErrValidate();
            registerPageAction.registerSurnameErrValidate();
        }

        [Test]
        public void Register8()
        {
            //REJESTRACJA nie wpisano żadnych danych - Łukaś
            MainPageAction mainPageAction = new MainPageAction(driver);
            RegisterPageAction registerPageAction = new RegisterPageAction(driver);

            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZarejestrujBT();
            registerPageAction.registerBTClick();
            registerPageAction.registerNameErrValidate();
            registerPageAction.registerSurnameErrValidate();
            registerPageAction.registerEmailErrValidate();
            registerPageAction.registerPasswordErrValidate();
        }
    }
}
