using Asserts.Logic.Trello.AddBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Trello.Feature.Contexts;
using WebAutomation.Logic.Trello.AddBoard;
using WebAutomation.Logic.Trello.Board;
using WebAutomation.Models.Trello.AddBoard;

namespace Trello.Feature.Steps
{
    [Binding]
    public class BoardSteps
    {
        private TrelloContext _context;

        public BoardSteps(TrelloContext context)
        {
            _context = context;
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
            AddBoardModal addBoard = _context.Session.GetValueByType<AddBoardModal>();

            AddBoardModel addBoardModel = table.CreateInstance<AddBoardModel>();
            addBoard.SetFields(addBoardModel);
            BoardPage boardPage = addBoard.CreateBoard();

            _context.Session.SaveValueByType(boardPage);
            _context.Session.SaveValueByType(addBoardModel);
        }

        [When(@"I click on ""(.*)"" in the board side menu")]
        public void WhenIClickOnInTheBoardSideMenu(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the board should exist in the Boards menu")]
        public void ThenTheBoardShouldExistInTheBoardsMenu()
        {
            AddBoardAsserts boardAsserts = new AddBoardAsserts(_context.Session.GetValueByType<BoardPage>(), _context.Session.GetValueByType<AddBoardModel>());
            boardAsserts.AssertContent();
        }

        [Then(@"the board should not exist in the Boards menu")]
        public void ThenTheBoardShouldNotExistInTheBoardsMenu()
        {
            BoardPage boardPage = _context.Session.GetValueByType<BoardPage>();
            AddBoardModel addBoardModel = _context.Session.GetValueByType<AddBoardModel>();



            ScenarioContext.Current.Pending();
        }
    }
}
