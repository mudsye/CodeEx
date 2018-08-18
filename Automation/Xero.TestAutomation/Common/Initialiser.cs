using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.IO;
using Xero.TestAutomation.DataStructures;

namespace Xero.TestAutomation.Common
{
    /// <summary>
    /// Static Intialiser class to load Selenium driver, test data
    /// </summary>
    public static class Initialiser
    {
        private static IWebDriver _Driver;
        public static IWebDriver Driver
        {
            get
            {
                if (_Driver == null)
                {
                    _Driver = GetDriver();
                }
                return _Driver;
            }
        }

        /// <summary>
        /// Closing broswer and dispose
        /// </summary>
        public static void Quit()
        {
            if (_Driver != null)
            {
                _Driver.Dispose();
                _Driver.Quit();
                _Driver = null;
                _Pages = null;
            }
        }

        private static Common.Pages _Pages;
        public static Common.Pages Pages
        {
            get
            {
                if (_Pages == null)
                {
                    _Pages = new Pages(Driver);
                }
                return _Pages;
            }
        }

        /// <summary>
        /// Loading test data for tests
        /// </summary>
        private static TestData _TestData;
        public static TestData TestData
        {
            get
            {
                if (_TestData == null)
                {
                    var configuredPath = AppConfig.TestDataPath;
                    var path = Path.Combine(Path.GetDirectoryName(typeof(AppConfig).Assembly.Location), "TestData", configuredPath);

                    if (configuredPath.StartsWith("file://"))
                    {
                        path = configuredPath.Replace("file://", string.Empty).Trim();
                    }

                    _TestData = new TestData(path);
                }
                return _TestData;
            }
        }

        /// <summary>
        /// Initializing the Selenium Driver object (supporting only Chrome, can be extended to include more browsers)
        /// </summary>
        /// <returns></returns>
        private static IWebDriver GetDriver()
        {
            IWebDriver driver = null;

            if (AppConfig.Browser.Equals("Chrome", StringComparison.OrdinalIgnoreCase))
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("-disable-extensions");
                options.AddArguments("-incognito");
                driver = new ChromeDriver(AppConfig.SeleniumDriverPath, options);

            }
            else
            {
                throw new Exception(String.Format("Browser '{0}' not supported", AppConfig.Browser));
            }

            return driver;
        }
    }
}
