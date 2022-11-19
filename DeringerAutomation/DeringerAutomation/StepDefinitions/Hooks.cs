
using SeleniumAutomation.Base;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Hooks: Browser
    {
        public PageObjectContext pageobjectcontext;
        public TestContext _testContext;

        public Hooks(PageObjectContext pageobjectcontext, DriverContext driverContext,TestContext testContext): base(driverContext)
        {
            this._testContext=testContext;
            this.pageobjectcontext = pageobjectcontext;
        }

        [BeforeScenario]
        public void FirstBeforeScenario()
        {
            string url = _testContext.Properties["url"].ToString();
            BrowserFactory browserFactory = new BrowserFactory(_driverContext);
            browserFactory.OpenBrowser(BrowserType.Chrome);
            _driverContext.browser.GoToUrl(url);
            
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverContext.Driver.Quit();
        }


    }
}