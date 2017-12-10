using Common.Selenium.Models;
using Common.Selenium.Models.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Selenium.Logic
{
    public static class Driver
    {
        public static IWebDriver GetDriver(DriverSettingsModel model)
        {
            IWebDriver driver = GetDriverByType(model.WebDriverType);

            //HACK: Not a super friendly way of doing this.. lock this setting in development only for now
            if (model.IsDisplayedOnSecondMonitor)
                driver.Manage().Window.Position = new System.Drawing.Point(2000, 1);

            if (model.IsMaximized)
                driver.Manage().Window.Maximize();

            return driver;
        }

        private static IWebDriver GetDriverByType(WebDriverType webDriverType)
        {
            switch (webDriverType)
            {
                case WebDriverType.Chrome:
                    return new ChromeDriver();
                case WebDriverType.Explorer:
                    return new InternetExplorerDriver();
                case WebDriverType.Firefox:
                    return new FirefoxDriver();
            }

            throw new ArgumentNullException("No browser specified");
        }
    }
}
