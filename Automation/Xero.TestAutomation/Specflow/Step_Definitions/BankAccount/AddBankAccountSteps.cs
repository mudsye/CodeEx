using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xero.TestAutomation.Pages;
using Xero.TestAutomation.Common;

namespace Xero.TestAutomation.Specflow.Step_Definitions.BankAccount
{
    [Binding]
    public class AddBankAccountSteps : AddBankAccountsPage
    {
        private BankAccountsPage BankAccountsPage;

        public AddBankAccountSteps() : base(Initialiser.Driver)
        {
            BankAccountsPage = Initialiser.Pages.BankAccountsPage;
        }

        [When(@"I add an (.*) bank account of type (.*)")]
        public void WhenIAddAnANZNZBankAccount(string bankName, string type)
        {
            BankAccountsPage.AddBankAccountButton.Click();

            SearchYourBank(bankName).Click();

            Random random = new Random();
            string accountName = String.Format("New" + random.Next(10000, 99999).ToString());
            ScenarioContext.Current.Add("AccountName", accountName);
            AccountName.SendKeys(accountName);

            AccountTypeCombobox.Click();

            SelectAccountTypeComboboxValue(type).Click();

            string accountNumber = random.Next(11111, 99999).ToString();
            ScenarioContext.Current.Add("AccountNumber", accountNumber);
            AccountNumber.SendKeys(accountNumber);

            ContinueButton.Click();
        }
    }
}
