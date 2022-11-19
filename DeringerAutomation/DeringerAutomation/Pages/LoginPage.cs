using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumAutomation.Base;
using SeleniumAutomation.WebElementExtension;
using SpecFlowProject1.StepDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.Pages
{
    public class LoginPage: Browser
    {
        public WebElementUtils webelementutils;
        
        public LoginPage(DriverContext driverContext): base(driverContext)
        {
           
            webelementutils = new WebElementUtils(driverContext);
           
        }
        public IWebElement lnkCustomerLogin => _driverContext.Driver.FindElement(By.XPath("//button[normalize-space()='Customer Login']"));
       
        public void CustomerLoginClick()
        {
            webelementutils.ClickWebElement(lnkCustomerLogin);
        }
    }
}
