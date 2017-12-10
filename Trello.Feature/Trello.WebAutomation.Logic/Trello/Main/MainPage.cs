using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Base;
using WebAutomation.Logic.Trello.Login;
using WebAutomation.Models;
using static Common.Selenium.Logic.Extensions;

namespace WebAutomation.Logic.Trello.Main
{
    public class MainPage : IWebAutomationPage
    {
        public MainPage(WebModel web) : base(web)
        {
        }

        public LoginPage GoToLoginPage()
        {
            Web.Driver.Navigate().GoToUrl(Constants.Sites.Trello);
            Web.Driver.FindElement(MainScreenReference.LoginButton).Click();
            Web.Driver.WaitForVisibleElement(LoginScreenReference.UserTextbox, Web.UniversalTimeout);

            return new LoginPage(Web);
        }
    }
}
