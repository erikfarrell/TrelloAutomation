using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation.Logic.Trello.Board
{
    public static class BoardPageScreenReference
    {
        public static By BoardsMenuButtonOrBoardMenu => By.XPath("//div[contains(@class, 'board-menu')]|//span[text()='Show Menu']/parent::a");
        public static By BoardMenuButton => By.XPath("//span[text()='Show Menu']/parent::a");
        public static By PermanentlyDeleteBoardLink => By.XPath("//a[contains(., 'Permanently Delete Board')]");
        public static By DeleteBoardConfirmationDeleteButton => By.XPath("//div[contains(@class, 'pop-over')]//input[@value='Delete']");
        public static By BoardNotFoundMessage => By.XPath("//h1[text()='Board not found.']");
    }
}
