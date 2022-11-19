using SeleniumAutomation.Base;
using SeleniumAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages
{
    public class PageObjectManager: Browser
    {
        public LoginPage lp;
        

        public PageObjectManager(DriverContext driverContext): base(driverContext)
        {
            
        }

        public LoginPage GetLoginPage()
        {

            return (lp == null ? lp = new LoginPage(_driverContext) : lp);
        }
    }
}
