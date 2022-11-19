using SeleniumAutomation.Base;
using SpecFlowProject1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.StepDefinitions
{
    public class PageObjectContext: Browser
    {
        public PageObjectManager pom;
       
        public PageObjectContext(DriverContext driverContext): base(driverContext)
        {
            pom= new PageObjectManager(driverContext);
        }

        public PageObjectManager GetPageObjectManager()
        {

            return pom;
        }
    }
}
