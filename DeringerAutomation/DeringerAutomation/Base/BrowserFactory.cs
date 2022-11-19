using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.Base
{
    public class BrowserFactory: Browser
    {
        public BrowserFactory(DriverContext driverContext): base(driverContext)
        {
            
        }


        public void OpenBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    _driverContext.Driver = new ChromeDriver();
                    _driverContext.browser = new Browser(_driverContext);
                    break;

            }
        }


    }
}
