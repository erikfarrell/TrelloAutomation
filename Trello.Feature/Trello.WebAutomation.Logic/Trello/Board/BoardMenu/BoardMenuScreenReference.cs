using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation.Logic.Trello.Board.BoardMenu
{
    public static class BoardMenuScreenReference
    {
        public static By BoardMenu => By.XPath("//div[contains(@class, 'board-menu')]");
        public static By MoreButton => By.XPath("//a[contains(@class, 'board-menu-navigation-item-link') and contains(., 'More')]");
        public static By CloseBoardButton => By.XPath("//a[contains(@class, 'board-menu-navigation-item-link') and contains(., 'Close Board')]");
        public static By CloseBoardConfirmationCloseButton => By.XPath("//div[contains(@class, 'pop-over')]//input[@value='Close']");
    }
}
