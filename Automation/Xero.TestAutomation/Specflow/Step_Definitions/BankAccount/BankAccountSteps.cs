using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xero.TestAutomation.Pages;
using Xero.TestAutomation.Common;
using Xero.TestAutomation.DataStructures;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Xero.TestAutomation.Specflow.Step_Definitions.BankAccount
{
    /// <summary>
    /// Step definitions for Bank Accounts screen
    /// </summary>
    [Binding]
    public class BankAccountSteps : BankAccountsPage
    {
        public BankAccountSteps() : base(Initialiser.Driver)
        {
        }
        
        [Then(@"the newly added Bank Account appears on Bank Account screen")]
        public void ThenTheNewlyAddedBankAccountAppearsOnBankAccountScreen()
        {
            string accountName = ScenarioContext.Current.Get<string>("AccountName");
            string accountNumber = ScenarioContext.Current.Get<string>("AccountNumber");
            Assertion.AssertContains(accountName, accountNumber, BankAccountDetail, StringComparison.OrdinalIgnoreCase);
        }
    }
}
