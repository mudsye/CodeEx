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
    /// Page object model for Add Bank Accounts screen
    /// </summary>
    public class AddBankAccountsPage : PageBase
    {
        public AddBankAccountsPage(IWebDriver driver) : base(driver) { }

        public IWebElement SearchYourBank(string text)
        {
            return this.Find(By.XPath("//li[text()='" + text + "']"));
        }

        public IWebElement AccountName
        {
            get { return this.Find(By.XPath("//input[contains(@id, 'accountname')]")); }
        }

        public IWebElement AccountTypeCombobox
        {
            get { return this.Find(By.XPath("//input[contains(@id, 'accounttype')]")); }
        }

        public IWebElement SelectAccountTypeComboboxValue (string text)
        {
            return this.FindElements(By.CssSelector("li.ba-combo-list-item")).
                FirstOrDefault(p => p.Text.Contains(text));
        }

        public IWebElement AccountNumber
        {
            get { return this.FindElements(By.XPath("//input[contains(@id, 'accountnumber')]")).FirstOrDefault(p => p.Displayed.Equals(true)); }
        }
        
        public IWebElement ContinueButton
        {
            get { return this.Find(By.PartialLinkText("Continue")); }
        }

    }
}
