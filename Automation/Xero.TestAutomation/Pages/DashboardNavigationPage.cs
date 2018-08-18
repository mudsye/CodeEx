using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Xero.TestAutomation.Pages
{
    /// <summary>
    /// Page object model for common Dashboard Navigation section on the Home page
    /// </summary>
    public class DashboardNavigationPage : PageBase
    {
        public DashboardNavigationPage(IWebDriver driver) : base(driver) { }

        public IWebElement AccountsMenu
        {
            get { return this.Find(By.LinkText("Accounts")); }
        }

        public IWebElement BankAccountsMenuItem
        {
            get { return this.Find(By.LinkText("Bank Accounts")); }
        }
    }
}
