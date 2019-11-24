using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TripAdvisor_testing
{
    class TestDodajAtrakcje : BaseTest
    {
        [Test]
        public void Atrakcja1()
        {
            //WALIDACJA FORMATKI
            MainPageAction mainPageAction = new MainPageAction(driver);
            LoginPageAction loginPageAction = new LoginPageAction(driver);
            AtractionPageAction atractionPageAction = new AtractionPageAction(driver);

            mainPageAction.clickDodajAtrakcjeBT();
            loginPageAction.positiveLogin();
            mainPageAction.clickDodajAtrakcjeBT();
            atractionPageAction.nazwaTXValidate();
            atractionPageAction.nazwaETSet("bar");
            atractionPageAction.opisTXValidate();
            atractionPageAction.opisETSet("najlepszy bar");
            atractionPageAction.localizationBTClick();
            atractionPageAction.imageETSet(GlobalVariables.atractionImagePositive);
            atractionPageAction.sendBTClick();
        }

        [Test]
        public void Atrakcja2()
        {
            //POPRAWNE DANE
            MainPageAction mainPageAction = new MainPageAction(driver);
            LoginPageAction loginPageAction = new LoginPageAction(driver);
            AtractionPageAction atractionPageAction = new AtractionPageAction(driver);

            mainPageAction.clickDodajAtrakcjeBT();
            loginPageAction.positiveLogin();
            mainPageAction.clickDodajAtrakcjeBT();
            atractionPageAction.nazwaETSet(GlobalVariables.atractionNamePositive);
            atractionPageAction.opisETSet(GlobalVariables.atractionOpisPositive);
            atractionPageAction.localizationBTClick();
            atractionPageAction.imageETSet(GlobalVariables.atractionImagePositive);
            atractionPageAction.sendBTClick();
        }

        [Test]
        public void Atrakcja3()
        {
            //PROBA DODANIA BEZ NAZWY
            MainPageAction mainPageAction = new MainPageAction(driver);
            LoginPageAction loginPageAction = new LoginPageAction(driver);
            AtractionPageAction atractionPageAction = new AtractionPageAction(driver);

            mainPageAction.clickDodajAtrakcjeBT();
            loginPageAction.positiveLogin();
            mainPageAction.clickDodajAtrakcjeBT();
            atractionPageAction.opisETSet(GlobalVariables.atractionOpisPositive);
            atractionPageAction.localizationBTClick();
            atractionPageAction.imageETSet(GlobalVariables.atractionImagePositive);
            atractionPageAction.sendBTClick();
        }

        [Test]
        public void Atrakcja4()
        {
            //PROBA DODANIA BEZ OPISU
            MainPageAction mainPageAction = new MainPageAction(driver);
            LoginPageAction loginPageAction = new LoginPageAction(driver);
            AtractionPageAction atractionPageAction = new AtractionPageAction(driver);

            mainPageAction.clickDodajAtrakcjeBT();
            loginPageAction.positiveLogin();
            mainPageAction.clickDodajAtrakcjeBT();
            atractionPageAction.nazwaETSet(GlobalVariables.atractionNamePositive);
            atractionPageAction.localizationBTClick();
            atractionPageAction.imageETSet(GlobalVariables.atractionImagePositive);
            atractionPageAction.sendBTClick();
        }

        [Test]
        public void Atrakcja5()
        {
            //PROBA DODANIA BEZ ZDJECIA
            MainPageAction mainPageAction = new MainPageAction(driver);
            LoginPageAction loginPageAction = new LoginPageAction(driver);
            AtractionPageAction atractionPageAction = new AtractionPageAction(driver);

            mainPageAction.clickDodajAtrakcjeBT();
            loginPageAction.positiveLogin();
            mainPageAction.clickDodajAtrakcjeBT();
            atractionPageAction.nazwaETSet(GlobalVariables.atractionNamePositive);
            atractionPageAction.opisETSet(GlobalVariables.atractionOpisPositive);
            atractionPageAction.localizationBTClick();
            atractionPageAction.sendBTClick();
        }
    }
}
