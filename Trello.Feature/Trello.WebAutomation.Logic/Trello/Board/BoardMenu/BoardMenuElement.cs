using Common.Selenium.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Base;
using WebAutomation.Models;

namespace WebAutomation.Logic.Trello.Board.BoardMenu
{
    public class BoardMenuElement : IWebAutomationElement
    {
        public BoardMenuElement(WebModel web) : base(web)
        {
        }

        //TODO: Working here
        public void ClickMore()
        {
            Web.Driver.FindClickableElement(BoardMenuScreenReference.MoreButton, Web.UniversalTimeout).Click();
        }

        public BoardPage ClickCloseBoard()
        {
            Web.Driver.FindClickableElement(BoardMenuScreenReference.CloseBoardButton, Web.UniversalTimeout).Click();
            Web.Driver.FindClickableElement(BoardMenuScreenReference.CloseBoardConfirmationCloseButton, Web.UniversalTimeout).Click();
            Web.Driver.WaitForInvisibleElement(BoardMenuScreenReference.BoardMenu, Web.UniversalTimeout);

            return new BoardPage(Web);
        }
    }
}
