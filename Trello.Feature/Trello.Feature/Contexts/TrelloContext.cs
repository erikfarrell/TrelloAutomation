using Common.Selenium.Logic;
using Common.Selenium.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Trello.Feature.Models;
using WebAutomation.Models;
using Xunit.Abstractions;

namespace Trello.Feature.Contexts
{
    [Binding]
    public class TrelloContext
    {
        public WebModel Web { get; private set; }

        public SessionModel Session { get; private set; }

        public TrelloContext()
        {
            IWebDriver driver =
                Driver.GetDriver(new DriverSettingsModel(Properties.Settings.Default.WebDriver,
                Properties.Settings.Default.IsMaximized,
                IsDisplayedOnSecondMonitor()));

            Session = new SessionModel();
            Web = new WebModel(driver, Properties.Settings.Default.UniversalTimeout);
        }

        public TrelloContext(ITestOutputHelper output) : this()
        {
            Session = new SessionModel(output);
        }

        //HACK: Locked to development only for now
        private bool IsDisplayedOnSecondMonitor()
        {
            if (System.Diagnostics.Debugger.IsAttached)
                return true;

            return false;
        }

        [AfterScenario]
        public void CleanUp()
        {
            Web.Driver?.Dispose();
        }
    }
}
