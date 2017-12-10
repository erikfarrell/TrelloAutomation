using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Base;
using WebAutomation.Logic.Trello.Board.TopBar;
using WebAutomation.Models;

namespace WebAutomation.Logic.Trello.Board
{
    public class BoardPage : IWebAutomationPage
    {        
        public TopBarElement TopBar =>  new TopBarElement(Web);
        
        public BoardPage(WebModel web) : base(web)
        {

        }
    }
}
