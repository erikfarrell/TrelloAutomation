using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation.Logic.Trello.Board.TopBar
{
    public static class TopBarScreenReference
    {
        public static By BoardsButton => By.XPath("//span[text()='Boards']");
        public static By MemberMenu => By.XPath("//a[@aria-label='Open Member Menu']");
    }
}
