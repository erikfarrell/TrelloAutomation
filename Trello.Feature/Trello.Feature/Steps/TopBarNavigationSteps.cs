using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Trello.Feature.Contexts;
using WebAutomation.Logic.Trello.AddBoard;
using WebAutomation.Logic.Trello.Board;
using Xunit.Abstractions;

namespace Trello.Feature.Steps
{
    [Binding]
    public class TopBarNavigationSteps
    {
        private TrelloContext _context;

        public TopBarNavigationSteps(TrelloContext context)
        {
            _context = context;
        }

        [Given(@"I click Create New Board\.\.\. from Top Menu => Boards")]
        public void GivenIClickCreateNewBoard_FromTopMenuBoards()
        {
            BoardPage board = _context.Session.GetValueByType<BoardPage>();

            AddBoardModal addBoard = board.TopBar.BoardsMenu.GoToCreateNewBoard();

            _context.Session.SaveValueByType(addBoard);
        }

        [Given(@"I open the ""(.*)"" board from the Boards menu")]
        public void GivenIOpenTheBoardFromTheBoardsMenu(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I open the Boards menu from top menu navigation")]
        public void GivenIOpenTheBoardsMenuFromTopMenuNavigation()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I open the Boards menu from top menu navigation")]
        public void WhenIOpenTheBoardsMenuFromTopMenuNavigation()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the board should appear")]
        public void ThenTheBoardShouldAppear()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the board should not appear")]
        public void ThenTheBoardShouldNotAppear()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
