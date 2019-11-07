using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace TripAdvisor_testing
{
    class MainPageAction : MainPageView
    {
        IWebDriver driver;
        public MainPageAction(IWebDriver driver) : base(driver)
        {
            
        }
        public void clickMainLogoIM()
        {
            mainLogoIM.Click();
        }
        public void clickListaAtrakcjiBT()
        {
            listaAtrakcjiBT.Click();
        }
        public void clickDodajAtrakcjeBT()
        {
            dodajAtrakcjeBT.Click();
        }
        public void clickUzytkownikBT()
        {
            uzytkownikBT.Click();
        }
        public void clickZalogujBT()
        {
            zalogujBT.Click();
        }
        public void clickZarejestrujBT()
        {
            zarejestrujBT.Click();
        }
        public void clickMojeKOntoBT()
        {
            mojeKontoBT.Click();
        }
    }
}
