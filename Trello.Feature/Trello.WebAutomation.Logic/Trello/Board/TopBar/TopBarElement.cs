using Common.Selenium.Logic;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Base;
using WebAutomation.Logic.Trello.Board.TopBar.BoardsMenu;
using WebAutomation.Models;

namespace WebAutomation.Logic.Trello.Board.TopBar
{
    public class TopBarElement : IWebAutomationElement
    {
        public BoardsMenuElement BoardsMenu => OpenBoardsMenu();

        public TopBarElement(WebModel web) : base(web)
        {
        }
        
        private BoardsMenuElement OpenBoardsMenu()
        {
            if (!BoardsMenuIsOpen())
            {
                Web.Driver.FindClickableElement(TopBarScreenReference.BoardsButton, Web.UniversalTimeout).Click();
            }
            Web.Driver.WaitForVisibleElement(BoardsMenuScreenReference.BoardsDrawer, Web.UniversalTimeout);

            return new BoardsMenuElement(Web);
        }

        private bool BoardsMenuIsOpen()
        {
            return Web.Driver.FindElement(BoardsMenuScreenReference.BoardsDrawer).Displayed;
        }
    }
}
