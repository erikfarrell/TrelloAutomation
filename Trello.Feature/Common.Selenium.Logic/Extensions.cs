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
        /// <summary>
        /// Finds a visible element via another element.
        /// Visibility means that the element is not only displayed but also has a height and width that is greater than 0.
        /// </summary>
        /// <param name="webElement">Parent web element of desired element</param>
        /// <param name="webDriver">The Selenium driver you're using</param>
        /// <param name="by">Query pattern</param>
        /// <param name="timeout">Time before failing element search</param>
        /// <returns></returns>
        public static IWebElement FindVisibleElement(this IWebElement webElement, IWebDriver webDriver, By by, TimeSpan timeout)
        {
            WaitForVisibleElement(webDriver, by, timeout);

            return webElement.FindElement(by);
        }

        /// <summary>
        /// Finds a visible element.
        /// Visibility means that the element is not only displayed but also has a height and width that is greater than 0.
        /// </summary>
        /// <param name="webDriver">The Selenium driver you're using</param>
        /// <param name="by">Query pattern</param>
        /// <param name="timeout">Time before failing element search</param>
        /// <returns></returns>
        public static IWebElement FindVisibleElement(this IWebDriver webDriver, By by, TimeSpan timeout)
        {
            WaitForVisibleElement(webDriver, by, timeout);

            return webDriver.FindElement(by);
        }

        /// <summary>
        /// Waits for a visible element.
        /// Visibility means that the element is not only displayed but also has a height and width that is greater than 0.
        /// </summary>
        /// <param name="webDriver">The Selenium driver you're using</param>
        /// <param name="by">Query pattern</param>
        /// <param name="timeout">Time before failing element search</param>
        public static void WaitForVisibleElement(this IWebDriver webDriver, By by, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, timeout);

            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        /// <summary>
        /// Waits for an invisible element
        /// </summary>
        /// <param name="webDriver">The Selenium driver you're using</param>
        /// <param name="by">Query pattern</param>
        /// <param name="timeout">Time before failing element search</param>
        public static void WaitForInvisibleElement(this IWebDriver webDriver, By by, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, timeout);

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }

        /// <summary>
        /// Waits for visible element to hit a stale reference
        /// </summary>
        /// <param name="webDriver">The Selenium driver you're using</param>
        /// <param name="webElement">Element to go stale</param>
        /// <param name="timeout">Time before failing element search</param>
        public static void WaitForStaleElement(this IWebDriver webDriver, IWebElement webElement, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, timeout);

            wait.Until(ExpectedConditions.StalenessOf(webElement));
        }

        /// <summary>
        /// Finds a clickable element.
        /// </summary>
        /// <param name="webDriver">The Selenium driver you're using</param>
        /// <param name="by">Query pattern</param>
        /// <param name="timeout">Time before failing element search</param>
        /// <returns></returns>
        public static IWebElement FindClickableElement(this IWebDriver webDriver, By by, TimeSpan timeout)
        {
            WaitForClickableElement(webDriver, by, timeout);

            return webDriver.FindElement(by);
        }

        /// <summary>
        /// Waits for a clickable element.
        /// </summary>
        /// <param name="webDriver">The Selenium driver you're using</param>
        /// <param name="by">Query pattern</param>
        /// <param name="timeout">Time before failing element search</param>
        public static void WaitForClickableElement(this IWebDriver webDriver, By by, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, timeout);

            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }
    }
}
