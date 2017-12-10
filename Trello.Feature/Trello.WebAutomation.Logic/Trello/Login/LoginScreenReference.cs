using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation.Logic.Trello.Login
{
    public static class LoginScreenReference
    {
        public static By UserTextbox => By.Id("user");
        public static By PasswordTextbox => By.Id("password");
        public static By LoginButton => By.Id("login");
    }
}
