using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Base;
using WebAutomation.Logic.Trello.Board;
using WebAutomation.Logic.Trello.Board.TopBar;
using WebAutomation.Models;
using static Common.Selenium.Logic.Extensions;

namespace WebAutomation.Logic.Trello.Login
{
    public class LoginPage : IWebAutomationPage
    {
        public LoginPage(WebModel web) : base(web)
        {
        }

        public BoardPage LogIn(string username, string password)
        {
            Web.Driver.FindElement(LoginScreenReference.UserTextbox).SendKeys(username);
            Web.Driver.FindElement(LoginScreenReference.PasswordTextbox).SendKeys(password);
            Web.Driver.FindElement(LoginScreenReference.LoginButton).Click();
            Web.Driver.WaitForVisibleElement(TopBarScreenReference.MemberMenu, Web.UniversalTimeout);

            return new BoardPage(Web);
        }
    }
}
