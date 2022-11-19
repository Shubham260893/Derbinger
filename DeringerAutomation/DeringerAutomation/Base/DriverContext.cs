using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.Base
{
    public class DriverContext
    {
        private IWebDriver _driver;
        public WebDriverWait wait;

        public IWebDriver Driver { get => _driver; set => _driver = value; }

        public Browser browser { get; set; }
    }

    
}
