using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripAdvisor_testing
{
    class AtractionPageView
    {
        private IWebDriver driver;
        public AtractionPageView(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//label[text()='Nazwa']")]
        protected IWebElement nazwaTX;

        [FindsBy(How = How.XPath, Using = "//*[text()='Nazwa']/following-sibling::div/div")]
        protected IWebElement nazwaErr;

        [FindsBy(How = How.Id, Using = "title")]
        protected IWebElement nazwaET;

        [FindsBy(How = How.XPath, Using = "//label[text()='Opis']")]
        protected IWebElement opisTX;

        [FindsBy(How = How.Id, Using = "description")]
        protected IWebElement opisET;
        

        [FindsBy(How = How.XPath, Using = "//*[text()='Opis']/following-sibling::div/div")]
        protected IWebElement opisErr;
        
      //  [FindsBy(How = How.XPath, Using = "//label[text()='image']")]
       // protected IWebElement image2BT;

        [FindsBy(How = How.XPath, Using = "//input[@type='file']")]
        protected IWebElement imageBT;

        [FindsBy(How = How.XPath, Using = "//label[text()='Zdjęcie']")]
        protected IWebElement imageTX;

        [FindsBy(How = How.Id, Using = "image")]
        protected IWebElement imageET;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        protected IWebElement sendBT;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-info']")]
        protected IWebElement localizationBT;
    }
}
