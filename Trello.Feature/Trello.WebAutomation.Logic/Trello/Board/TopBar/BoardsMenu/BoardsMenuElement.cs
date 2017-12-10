using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Base;
using WebAutomation.Models;
using static Common.Selenium.Logic.Extensions;

namespace WebAutomation.Logic.Trello.Board.TopBar.BoardsMenu
{
    public class BoardsMenuElement : IWebAutomationElement
    {
        public BoardsMenuElement(WebModel web) : base(web)
        {
        }

        public void OpenLink(string link)
        {
            Web.Driver.FindElement(By.XPath("//span[text()='Boards']")).Click();
            BoardsDrawer().FindVisibleElement(Web.Driver, By.XPath($"//a[text()='{link}']"), Web.UniversalTimeout).Click();
        }

        private IWebElement BoardsDrawer()
        {
            return Web.Driver.FindElement(By.Id("boards-drawer"));
        }
    }
}
