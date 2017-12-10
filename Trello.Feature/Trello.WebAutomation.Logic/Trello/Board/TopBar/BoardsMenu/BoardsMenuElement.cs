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
            Web.Driver.FindElement(BoardsMenuScreenReference.BoardsButton).Click();
            BoardsDrawer().FindVisibleElement(Web.Driver, BoardsMenuScreenReference.CreateNewBoardLink, Web.UniversalTimeout).Click();
            Web.Driver.WaitForVisibleElement(AddBoardScreenReference.AddBoardTitleTextbox, Web.UniversalTimeout);

            return new AddBoardModal(Web);
        }

        private IWebElement BoardsDrawer()
        {
            return Web.Driver.FindElement(BoardsMenuScreenReference.BoardsDrawer);
        }
    }
}
