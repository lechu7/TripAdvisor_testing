using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TripAdvisor_testing
{
    class TestLogin : BaseTest
    {
        [Test]
        public void Login1()
        {
            //WALIDACJA FORMATKI
            MainPageAction mainPageAction = new MainPageAction(driver);
            LoginPageAction loginPageAction = new LoginPageAction(driver);

       
            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZalogujBT();
            loginPageAction.zalogujTitleTXValidate();
            loginPageAction.emailTXValidate();
            loginPageAction.emailETSet("login");
            loginPageAction.passwordTXValidate();
            loginPageAction.passwordETSet("password");
            loginPageAction.saveTXValidate();
            loginPageAction.saveCBClick();
            loginPageAction.loginBTClick();
            
        }

        [Test]
        public void Login2()
        {
            //POZYTYWNE LOGOWANIE
            MainPageAction mainPageAction = new MainPageAction(driver);
            LoginPageAction loginPageAction = new LoginPageAction(driver);

            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZalogujBT();
            loginPageAction.positiveLogin();
            loginPageAction.positiveLoginTXValidate();
        }

        [Test]
        public void Login3()
        {
            //NEGATYWNE LOGOWANIE
            MainPageAction mainPageAction = new MainPageAction(driver);
            LoginPageAction loginPageAction = new LoginPageAction(driver);

            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZalogujBT();
            loginPageAction.emailETSet(GlobalVariables.emailNegative);
            loginPageAction.passwordETSet(GlobalVariables.passwordNegative);
            loginPageAction.loginBTClick();
            loginPageAction.negativeLoginTXValidate();
        }
        [Test]
        public void Login4()
        {
            //PROBA LOGOWANIA BEZ LOGINU
            MainPageAction mainPageAction = new MainPageAction(driver);
            LoginPageAction loginPageAction = new LoginPageAction(driver);

            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZalogujBT();
            loginPageAction.passwordETSet(GlobalVariables.passwordPositive);
            loginPageAction.loginBTClick();
            loginPageAction.emailErrValidate();
        }
        [Test]
        public void Login5()
        {
            //PROBA LOGOWANIA BEZ HASLA
            MainPageAction mainPageAction = new MainPageAction(driver);
            LoginPageAction loginPageAction = new LoginPageAction(driver);

            mainPageAction.clickUzytkownikBT();
            mainPageAction.clickZalogujBT();
            loginPageAction.emailETSet(GlobalVariables.emailPositive);
            loginPageAction.loginBTClick();
            loginPageAction.passwordErrValidate();
        }
    }
}
