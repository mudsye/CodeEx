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

namespace Xero.TestAutomation.Specflow.Step_Definitions.Common
{
    /// <summary>
    /// Common step definitions for navigating on Dashboard menu section
    /// </summary>
    [Binding]
    public class DashboardNavigationSteps : DashboardNavigationPage
    {
        public DashboardNavigationSteps() : base(Initialiser.Driver)
        {
        }

        [Given(@"I navigate to Bank Accounts screen")]
        public void GivenINavigateToBankAccountsScreen()
        {
            WebDriverWait wait = new WebDriverWait(Initialiser.Driver, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("xn-h-menu")));
            AccountsMenu.Click();

            wait.Until(ExpectedConditions.ElementExists(By.LinkText("Bank Accounts")));
            BankAccountsMenuItem.Click();
        }

    }
}
