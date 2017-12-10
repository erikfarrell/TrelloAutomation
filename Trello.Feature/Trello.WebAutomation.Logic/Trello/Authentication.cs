using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Models;
using static Common.Selenium.Logic.Extensions;

namespace WebAutomation.Logic.Trello
{
    public class Authentication
    {
        private WebModel _web;

        public Authentication(WebModel webModel)
        {
            _web = webModel;
        }

        public void LogIn(string username, string password)
        {
            _web.Driver.Navigate().GoToUrl(Constants.Sites.Trello);
            _web.Driver.FindElement(By.XPath("//a[text()='Log In']")).Click();
            _web.Driver.WaitForVisibleElement(By.Id("user"), _web.UniversalTimeout);
            _web.Driver.FindElement(By.Id("user")).SendKeys(username);
            _web.Driver.FindElement(By.Id("password")).SendKeys(password);
            _web.Driver.FindElement(By.Id("login")).Click();
            _web.Driver.WaitForVisibleElement(By.XPath("//a[@aria-label='Open Member Menu']"), _web.UniversalTimeout);
        }
    }
}
