using FluentAssertions;
using SeleniumAutomation.Base;
using SeleniumAutomation.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions;

    [Binding]
    public class LoginStepdef: Browser
    {
    public PageObjectContext testContext;
    public LoginPage lp;
    
      
        public LoginStepdef(PageObjectContext testContext,DriverContext driverContext): base(driverContext)
        {
            this.testContext = testContext;
        lp = testContext.GetPageObjectManager().GetLoginPage();
        }
        [Given(@"user click on Customer Login")]
        public void GivenUserClickOnCustomerLogin()
        {
                Thread.Sleep(5000);
              lp.CustomerLoginClick();
        }

        [When(@"user select Customer Name")]
        public void WhenUserSelectCustomerName()
        {
            
        }

        [Then(@"user click on deposits")]
        public void ThenUserClickOnDeposits()
        {
            
        }
    }

