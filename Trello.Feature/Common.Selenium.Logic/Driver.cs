using Common.Selenium.Logic.Enums;
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
        public static IWebDriver GetDriverByType(string webDriverType)
        {
            return GetDriverByType((WebDriverType)Enum.Parse(typeof(WebDriverType), webDriverType));
        }

        public static IWebDriver GetDriverByType(WebDriverType webDriverType)
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
