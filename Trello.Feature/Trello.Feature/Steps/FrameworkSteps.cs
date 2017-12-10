using Common.Logic.Helpers;
using Common.Selenium.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Trello.Feature.Contexts;
using WebAutomation.Logic.Trello;
using WebAutomation.Logic.Trello.Board;

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

        [Given(@"I log in to the test Trello instance")]
        public void GivenILogInToTheTestTrelloInstance()
        {
            Authentication authentication = new Authentication(_context.Web);

            BoardElement board = authentication.LogIn(
                Properties.Settings.Default.TrelloUsername, 
                Crypto.Decrypt(Properties.Settings.Default.TrelloEncryptedPassword, 
                Constants.Keys.Passphrase));

            _context.Session.SaveValueByType(board);
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
