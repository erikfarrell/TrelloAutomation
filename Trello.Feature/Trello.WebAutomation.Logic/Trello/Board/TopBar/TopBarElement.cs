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
        public BoardsMenuElement BoardsMenu
        {
            get { return new BoardsMenuElement(Web); }
        }

        public TopBarElement(WebModel web) : base(web)
        {
        }
    }
}
