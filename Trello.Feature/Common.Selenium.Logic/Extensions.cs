using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Selenium.Logic
{
    public static class Extensions
    {
        public static void WaitForVisibleElement(this IWebDriver webDriver, By by, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, timeout);

            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
