using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Trello.Feature.Steps
{
    [Binding]
    public class BoardSteps
    {
        private FeatureContext _context;

        public BoardSteps(FeatureContext featureContext)
        {
            _context = featureContext;
        }

        [Given(@"I open the board side menu")]
        public void GivenIOpenTheBoardSideMenu()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click on ""(.*)"" in the board side menu")]
        public void GivenIClickOnInTheBoardSideMenu(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I create a new board with the following values")]
        public void WhenICreateANewBoardWithTheFollowingValues(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on ""(.*)"" in the board side menu")]
        public void WhenIClickOnInTheBoardSideMenu(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
