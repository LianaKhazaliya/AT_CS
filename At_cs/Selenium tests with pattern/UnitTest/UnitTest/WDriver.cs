using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    class WDriver
    {
        private IWebDriver driver;

        private WDriver() {
            driver = new IWebDriver();
        }
        
        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                new WDriver();
            }
            return driver;
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}
