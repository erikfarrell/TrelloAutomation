using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Base;
using WebAutomation.Logic.Trello.Board;
using WebAutomation.Models;
using static Common.Selenium.Logic.Extensions;

namespace WebAutomation.Logic.Trello
{
    public class LoginPage : IWebAutomationPage
    {
        public LoginPage(WebModel web) : base(web)
        {
        }

        public BoardPage LogIn(string username, string password)
        {
            Web.Driver.FindElement(By.Id("user")).SendKeys(username);
            Web.Driver.FindElement(By.Id("password")).SendKeys(password);
            Web.Driver.FindElement(By.Id("login")).Click();
            Web.Driver.WaitForVisibleElement(By.XPath("//a[@aria-label='Open Member Menu']"), Web.UniversalTimeout);

            return new BoardPage(Web);
        }
    }
}
