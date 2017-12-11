using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Base;
using WebAutomation.Logic.Trello.AddBoard;
using WebAutomation.Models;
using static Common.Selenium.Logic.Extensions;

namespace WebAutomation.Logic.Trello.Board.TopBar.BoardsMenu
{
    public class BoardsMenuElement : IWebAutomationElement
    {
        public BoardsMenuElement(WebModel web) : base(web)
        {
        }

        public AddBoardModal GoToCreateNewBoard()
        {
            BoardsDrawer().FindVisibleElement(Web.Driver, BoardsMenuScreenReference.CreateNewBoardLink, Web.UniversalTimeout).Click();
            Web.Driver.WaitForVisibleElement(AddBoardScreenReference.AddBoardTitleTextbox, Web.UniversalTimeout);

            return new AddBoardModal(Web);
        }
        
        public List<IWebElement> GetBoardsButtonsFromMenu()
        {
            return BoardsDrawer().FindElements(BoardsMenuScreenReference.BoardButtons).Where(w => w.Displayed).ToList();
        }

        public List<string> GetBoardButtonNamesFromMenu()
        {
            var test = BoardsDrawer().FindElements(BoardsMenuScreenReference.BoardButtonNames);
            var test2 = BoardsDrawer().FindElements(BoardsMenuScreenReference.BoardButtonNames).Where(w => w.Displayed);

            return BoardsDrawer().FindElements(BoardsMenuScreenReference.BoardButtonNames).Where(w => w.Displayed).Select(e => e.GetAttribute("title")).ToList();
        }

        public BoardPage CloseBoardsDrawer()
        {
            Web.Driver.FindClickableElement(TopBarScreenReference.BoardsButton, Web.UniversalTimeout).Click();
            Web.Driver.WaitForInvisibleElement(BoardsMenuScreenReference.BoardsDrawer, Web.UniversalTimeout);

            return new BoardPage(Web);
        }

        private IWebElement BoardsDrawer()
        {
            return Web.Driver.FindVisibleElement(BoardsMenuScreenReference.BoardsDrawer, Web.UniversalTimeout);
        }
    }
}
