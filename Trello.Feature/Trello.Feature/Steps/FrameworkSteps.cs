using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Trello.Feature.Steps
{
    [Binding]
    public class FrameworkSteps
    {
        private FeatureContext _context;

        public FrameworkSteps(FeatureContext featureContext)
        {
            _context = featureContext;
        }

        [Given(@"I open Google Chrome")]
        public void GivenIOpenGoogleChrome()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string p0)
        {
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
