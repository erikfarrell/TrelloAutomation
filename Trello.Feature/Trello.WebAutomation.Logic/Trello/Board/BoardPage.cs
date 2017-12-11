using Common.Selenium.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Base;
using WebAutomation.Logic.Trello.Board.BoardMenu;
using WebAutomation.Logic.Trello.Board.TopBar;
using WebAutomation.Models;

namespace WebAutomation.Logic.Trello.Board
{
    public class BoardPage : IWebAutomationPage
    {        
        public TopBarElement TopBar => new TopBarElement(Web);
        public BoardMenuElement BoardMenu => OpenBoardMenu();
        
        public BoardPage(WebModel web) : base(web)
        {

        }

        public void ClickPermanentlyDeleteBoard()
        {
            Web.Driver.FindClickableElement(BoardPageScreenReference.PermanentlyDeleteBoardLink, Web.UniversalTimeout).Click();
            Web.Driver.FindClickableElement(BoardPageScreenReference.DeleteBoardConfirmationDeleteButton, Web.UniversalTimeout).Click();
            Web.Driver.WaitForVisibleElement(BoardPageScreenReference.BoardNotFoundMessage, Web.UniversalTimeout);
        }

        private BoardMenuElement OpenBoardMenu()
        {
            Web.Driver.WaitForVisibleElement(BoardPageScreenReference.BoardsMenuButtonOrBoardMenu, Web.UniversalTimeout);

            if (!BoardMenuIsOpen())
            {
                Web.Driver.FindClickableElement(BoardPageScreenReference.BoardMenuButton, Web.UniversalTimeout).Click();
            }
            Web.Driver.WaitForVisibleElement(BoardMenuScreenReference.BoardMenu, Web.UniversalTimeout);

            return new BoardMenuElement(Web);
        }

        private bool BoardMenuIsOpen()
        {
            return Web.Driver.FindElement(BoardMenuScreenReference.BoardMenu).Displayed;
        }
    }
}
