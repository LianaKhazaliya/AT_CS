using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var chrome = new ChromeDriver();
            chrome.Navigate().GoToUrl("https://www.avianca.com.br/pt/");

            chrome.FindElementById("sp-origem").Click();
            chrome.FindElementByCssSelector("input.form-control.txt-center.txt-fixo.search-field").SendKeys("Adis");
            chrome.FindElementByCssSelector("a.fz-20.tac").Click();

            chrome.FindElementById("sp-destino").Click();
            chrome.FindElementByCssSelector("#dv-destino input.form-control.txt-center.txt-fixo.search-field").SendKeys("Bra");
            chrome.FindElementByCssSelector("#dv-destino a.fz-20.tac").Click();

            chrome.FindElementById("dateidaPassagem").Click();
            for(int i=0; i< 5; i++)
            {
                chrome.FindElementById("dateidaPassagem").SendKeys(Keys.Backspace);
                chrome.FindElementById("dateidaPassagem").SendKeys(Keys.Delete);
            }
            chrome.FindElementById("dateidaPassagem").SendKeys("22");
            chrome.FindElementById("dateidaPassagem").SendKeys("10");
            chrome.FindElementById("dateidaPassagem").SendKeys("2018");
            chrome.FindElementById("btn-buscar").SendKeys(Keys.Enter);

            var el = chrome.FindElementById("dateidaPassagem");
            var classNames = el.GetAttribute("className");
            if (!classNames.Contains("error-field"))
            {
                throw new AssertFailedException();
            }
        }
    }
}
