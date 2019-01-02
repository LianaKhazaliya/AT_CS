using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class OrderPage
    {
        private IWebDriver driver;
        private const string Url = "https://www.avianca.com.br/pt/";

        By originInputForFocusing = By.CssSelector("#sp-origem");
        By inputForSearchingOrigin = By.CssSelector("input.form-control.txt-center.txt-fixo.search-field");
        By inputForCheckingOriginSearchValue = By.CssSelector("input#origemPassagem.form-control.txt-center.txt-fixo.value-field");
        By selecteOriginItem = By.CssSelector("a.fz-20.tac");
        
        By destinationInputForFocusing = By.CssSelector("#sp-destino");
        By inputForSearchingDestination = By.CssSelector("#dv-destino input.form-control.txt-center.txt-fixo.search-field");
        By inputForCheckingDestinationSearchValue = By.CssSelector("input#origemPassagem.form-control.txt-center.txt-fixo.value-field");
        By selecteDestinationItem = By.CssSelector("#dv-destino a.fz-20.tac");

        By dateInput = By.CssSelector("#dateidaPassagem");

        By submitButton = By.CssSelector("#btn-buscar");

         public OrderPage()
        {
            this.driver = WDriver.GetDriver();
        }

        public void OpenOrderPage()
        {
            GoToUrl(Url);
        }

        public void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void SelectInputForSearchingOrigin()
        {
            driver.FindElement(originInputForFocusing).Click();
        }

        public void SelectOriginItem()
        {
            driver.FindElement(selecteOriginItem).Click();
        }

        public IWebElement GetInputForSearchingOrigin()
        {
            return driver.FindElement(inputForSearchingOrigin);
        }

        public IWebElement GetInputForCheckingOriginSearchValue()
        {
            return driver.FindElement(inputForCheckingOriginSearchValue);
        }

        public void SelectInputForSearchingDestination()
        {
            driver.FindElement(destinationInputForFocusing).Click();
        }

        public void SelectDestinationItem()
        {
            driver.FindElement(selecteDestinationItem).Click();
        }

        public IWebElement GetInputForSearchingDestination()
        {
            return driver.FindElement(inputForSearchingDestination);
        }

        public IWebElement GetInputForCheckingDestinationSearchValue()
        {
            return driver.FindElement(inputForCheckingDestinationSearchValue);
        }

        public void SelectDateInput()
        {
            driver.FindElement(dateInput).Click();
        }

        public IWebElement GetDateInput()
        {
            return driver.FindElement(dateInput); 
        }

        public void ClearDateInput()
        {
            var el = GetDateInput();

            for (int i = 0; i < 5; i++)
            {
                el.SendKeys(Keys.Backspace);
                el.SendKeys(Keys.Delete);
            }
        }

        public void SetDateValues(string[] val)
        {
            var el = GetDateInput();

            for (int i=0; i<val.Length; i++)
            {
                el.SendKeys(val[i]);
            }
        }

        public void SubmitForm()
        {
            driver.FindElement(submitButton).SendKeys(Keys.Enter);
        }

        public void SetValue(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public void SubmitTheData(IWebElement element)
        {
            element.SendKeys(Keys.Enter);
        }
        
    }
}
