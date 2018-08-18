using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Xero.TestAutomation.DataStructures;

namespace Xero.TestAutomation.Pages
{
    /// <summary>
    /// Base page for common method inherited in Application page object model classes
    /// </summary>
    public class PageBase
    {
        public IWebDriver _driver { private set; get; }

        /// <summary>
        /// Base constructor for selenium driver object
        /// </summary>
        /// <param name="driver"></param>
        public PageBase(IWebDriver driver)
        {
            _driver = driver;
            _driver.Manage().Window.Maximize();

            _driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 30);
        }
        
        /// <summary>
        /// Find macthing element based on selenium selector
        /// Abtract away in case we need to add some extra logic (e.g. waiting for an element to
        /// appear if it doesn't exist right away)
        /// </summary>
        /// <param name="by">Mechanism to search element in Selenium</param>
        /// <param name="timeout">time to search for element</param>
        /// <returns></returns>
        public IWebElement Find(By by, int timeout = 10000)
        {
            IWebElement element = null;
            
            Stopwatch watch = new Stopwatch();
            watch.Start();

            while (element == null)
            {
                if (watch.ElapsedMilliseconds > timeout)
                    break;

                Thread.Sleep(100);

                element = this._driver.FindElements(by).FirstOrDefault();
            }

            return element;
        }

        /// <summary>
        /// Find multiple elements based on selenium selector
        /// Abtract away in case we need to add some extra logic (e.g. waiting for an element to
        /// appear if it doesn't exist right away)
        /// </summary>
        /// <param name="by">Mechanism to search element in Selenium</param>
        /// <param name="timeout">time to search for element</param>
        /// <returns></returns>
        public IReadOnlyCollection<IWebElement> FindElements(By by, int timeout = 10000)
        {
            IReadOnlyCollection<IWebElement> element = null;

            Stopwatch watch = new Stopwatch();
            watch.Start();

            while (element == null)
            {
                if (watch.ElapsedMilliseconds > timeout)
                    break;

                Thread.Sleep(100);

                element = this._driver.FindElements(by);
            }

            return element;
        }
    }
}
