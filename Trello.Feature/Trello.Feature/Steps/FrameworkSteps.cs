using Common.Selenium.Logic;
using Common.Selenium.Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Trello.Feature.Contexts;

namespace Trello.Feature.Steps
{
    [Binding]
    public class FrameworkSteps
    {
        private TrelloContext _context;

        public FrameworkSteps(TrelloContext context)
        {
            _context = context;
        }

        [Given(@"I open Google Chrome")]
        public void GivenIOpenGoogleChrome()
        {
            _context.WebDriver = Driver.GetDriverByType(WebDriverType.Chrome);;
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string p0)
        {
            _context.WebDriver.Navigate().GoToUrl(p0);
            ScenarioContext.Current.Pending();
        }

        [Given(@"I log in as ""(.*)""")]
        public void GivenILogInAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click ""(.*)"" in the confirmation box")]
        public void WhenIClickInTheConfirmationBox(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click ""(.*)"" in the main panel")]
        public void WhenIClickInTheMainPanel(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
