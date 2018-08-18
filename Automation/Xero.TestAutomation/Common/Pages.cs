using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Xero.TestAutomation.Pages;

namespace Xero.TestAutomation.Common
{
    /// <summary>
    /// Pages used between different specflow step definitions can be added here
    /// </summary>
    public class Pages
    {
        private IWebDriver _driver;

        public Pages(IWebDriver driver)
        {
            this._driver = driver;
        }

        private BankAccountsPage _BankAccountsPage;
        public BankAccountsPage BankAccountsPage
        {
            get { if (_BankAccountsPage == null) _BankAccountsPage = new BankAccountsPage(this._driver); return _BankAccountsPage; }
            set { _BankAccountsPage = value; }
        }
    }
}
