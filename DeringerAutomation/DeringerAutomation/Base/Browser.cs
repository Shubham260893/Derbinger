using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.Base
{
    public class Browser
    {
       public readonly DriverContext _driverContext;
        public BrowserType Type { get; set; }

        public void GoToUrl(String url)
        {
            _driverContext.Driver.Url = url;
        }
        public Browser(DriverContext driverContext)
        {
            _driverContext = driverContext;
        }


    }
        

    public enum BrowserType
    {
        Chrome,
        Firefox

    }
}
