using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Trello.Board.TopBar.BoardsMenu;
using WebAutomation.Models;

namespace WebAutomation.Logic.Trello.Board.TopBar
{
    public class TopBarElement
    {
        private WebModel _web;
        public BoardsMenuElement BoardsMenu { get; set; }

        public TopBarElement(WebModel webModel)
        {
            _web = webModel;

            BoardsMenu = new BoardsMenuElement(webModel);
        }
    }
}
