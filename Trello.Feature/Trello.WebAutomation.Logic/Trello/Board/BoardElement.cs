using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Trello.Board.TopBar;
using WebAutomation.Models;

namespace WebAutomation.Logic.Trello.Board
{
    public class BoardElement
    {
        private WebModel _web;
        public TopBarElement TopBar { get; set; }
        
        public BoardElement(WebModel webModel)
        {
            _web = webModel;
            TopBar = new TopBarElement(webModel);
        }
    }
}
