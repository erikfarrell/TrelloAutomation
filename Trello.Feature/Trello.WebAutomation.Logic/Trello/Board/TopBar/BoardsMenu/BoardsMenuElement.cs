using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Models;
using static Common.Selenium.Logic.Extensions;

namespace WebAutomation.Logic.Trello.Board.TopBar.BoardsMenu
{
    public class BoardsMenuElement
    {
        private WebModel _web;

        public BoardsMenuElement(WebModel webModel)
        {
            _web = webModel;
        }

        public void OpenLink(string link)
        {
            _web.Driver.FindElement(By.XPath("//span[text()='Boards']")).Click();
            BoardsDrawer().FindVisibleElement(_web.Driver, By.XPath($"//a[text()='{link}']"), _web.UniversalTimeout).Click();
        }

        private IWebElement BoardsDrawer()
        {
            return _web.Driver.FindElement(By.Id("boards-drawer"));
        }
    }
}
