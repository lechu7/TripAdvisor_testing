using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TripAdvisor_testing
{
    class MainPageView
    {
        private IWebDriver driver;
        public MainPageView(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "Logo_Logo__3IWnu")]
        protected IWebElement mainLogoIM;

        [FindsBy(How = How.XPath, Using = "//a[text()='Lista atrakcji']")]
        protected IWebElement listaAtrakcjiBT;

        [FindsBy(How = How.XPath, Using = "//a[text()='Dodaj atrakcję']")]
        protected IWebElement dodajAtrakcjeBT;

        [FindsBy(How = How.XPath, Using = "//a[text()='Użytkownik']")]
        protected IWebElement uzytkownikBT;

        [FindsBy(How = How.XPath, Using = "//a[text()='Zaloguj']")]
        protected IWebElement zalogujBT;

        [FindsBy(How = How.XPath, Using = "//a[text()='Wyloguj']")]
        protected IWebElement wylogujBT;

        [FindsBy(How = How.XPath, Using = "//a[text()='Zarejestruj']")]
        protected IWebElement zarejestrujBT;

        [FindsBy(How = How.XPath, Using = "//a[text()='Moje konto']")]
        protected IWebElement mojeKontoBT;
    }
}

