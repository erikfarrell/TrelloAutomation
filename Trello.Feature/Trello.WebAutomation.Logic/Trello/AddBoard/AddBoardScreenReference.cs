using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation.Logic.Trello.AddBoard
{
    public static class AddBoardScreenReference
    {
        public static By AddBoardTitleTextbox => By.XPath("//input[@placeholder='Add board title']");
    }
}
