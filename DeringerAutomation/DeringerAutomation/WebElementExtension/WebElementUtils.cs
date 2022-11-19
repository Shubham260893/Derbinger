using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumAutomation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.WebElementExtension
{
    public class WebElementUtils:Browser
    {
       
        public WebElementUtils(DriverContext driverContext): base(driverContext)
        {
            
        }

        public void ClickWebElement(IWebElement element)
        {
            _driverContext.wait = new WebDriverWait(_driverContext.Driver, TimeSpan.FromSeconds(30));
            _driverContext.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

    }
}
