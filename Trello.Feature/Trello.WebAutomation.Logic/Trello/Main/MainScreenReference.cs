using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation.Logic.Trello.Main
{
    public static class MainScreenReference
    {
        public static By LoginButton => By.XPath("//a[text()='Log In']");
    }
}
