using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xero.TestAutomation.Pages;
using Xero.TestAutomation.Common;
using Xero.TestAutomation.DataStructures;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Xero.TestAutomation.Pages
{
    /// <summary>
    /// Page object model for Bank Accounts screen
    /// </summary>
    public class BankAccountsPage : PageBase
    {
        public BankAccountsPage(IWebDriver driver) : base(driver) { }

        public IWebElement AddBankAccountButton
        {
            get { return this.Find(By.PartialLinkText("Add Bank Account")); }
        }

        public IReadOnlyCollection<IWebElement> BankAccountDetail
        {
            get { return this.FindElements(By.CssSelector("a[class='bank-name global']")); }
        }
    }
}
