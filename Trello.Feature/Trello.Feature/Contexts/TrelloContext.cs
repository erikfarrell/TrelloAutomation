using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Feature.Models;

namespace Trello.Feature.Contexts
{
    public class TrelloContext
    {
        public IWebDriver WebDriver { get; set; }

        public SessionModel SessionModel { get; private set; }

        public TrelloContext()
        {
            SessionModel = new SessionModel();
        }
    }
}
