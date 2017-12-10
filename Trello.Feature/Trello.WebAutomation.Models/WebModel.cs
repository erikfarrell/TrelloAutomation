using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation.Models
{
    public class WebModel
    {
        public IWebDriver Driver { get; private set; }
        public TimeSpan UniversalTimeout { get; private set; }

        public WebModel(IWebDriver driver, TimeSpan universalTimeout)
        {
            Driver = driver;
            UniversalTimeout = universalTimeout;
        }
    }
}
