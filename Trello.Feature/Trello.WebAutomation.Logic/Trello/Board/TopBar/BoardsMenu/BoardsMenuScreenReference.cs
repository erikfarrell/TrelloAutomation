using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation.Logic.Trello.Board.TopBar.BoardsMenu
{
    public static class BoardsMenuScreenReference
    {
        public static By BoardsDrawer => By.Id("boards-drawer");
        public static By BoardsButton => By.XPath("//span[text()='Boards']");
        public static By CreateNewBoardLink => By.XPath($"//a[text()='Create new board…']");
        public static By BoardButtons => By.XPath("//a[contains(@class, 'js-open-board')]");
        public static By BoardButtonNames => By.XPath("//a[contains(@class, 'js-open-board')]//span[@title]");
    }
}
