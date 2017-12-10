using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Base;
using WebAutomation.Models;
using static Common.Selenium.Logic.Extensions;

namespace WebAutomation.Logic.Trello
{
    public class MainPage : IWebAutomationPage
    {
        public MainPage(WebModel web) : base(web)
        {
        }

        public LoginPage GoToLoginPage()
        {
            Web.Driver.Navigate().GoToUrl(Constants.Sites.Trello);
            Web.Driver.FindElement(By.XPath("//a[text()='Log In']")).Click();
            Web.Driver.WaitForVisibleElement(By.Id("user"), Web.UniversalTimeout);

            return new LoginPage(Web);
        }
    }
}
