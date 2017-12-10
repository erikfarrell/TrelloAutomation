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

        public TrelloContext(ITestOutputHelper output)
        {
            Session = new SessionModel();
            Web = new WebModel();

            output.WriteLine("test" + IsDisplayedOnSecondMonitor().ToString());

            Web.Driver = Driver.GetDriver(new DriverSettingsModel(Properties.Settings.Default.WebDriver, Properties.Settings.Default.IsMaximized, IsDisplayedOnSecondMonitor()));
        }

        private bool IsDisplayedOnSecondMonitor()
        {
            if (System.Diagnostics.Debugger.IsAttached)
                return true;

            return false;
        }

        [AfterScenario]
        public void CleanUp()
        {
            Web.Driver.Dispose();
        }
    }
}
