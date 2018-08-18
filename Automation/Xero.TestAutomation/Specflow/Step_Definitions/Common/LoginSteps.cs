using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xero.TestAutomation.Pages;
using Xero.TestAutomation.Common;
using Xero.TestAutomation.DataStructures;

namespace Xero.TestAutomation.Specflow.Step_Definitions.Common
{
    [Binding]
    public class LoginSteps : LoginPage
    {
        private TestData TestData;

        public LoginSteps() : base(Initialiser.Driver)
        {
            TestData = Initialiser.TestData;
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Initialiser.Quit();
        }

        [Given(@"I login to any Xero Organisation")]
        public void GivenILoginToAnyXeroOrganisation()
        {
            _driver.Navigate().GoToUrl(AppConfig.Url);
            UsernameTextBox.SendKeys(TestData.LoginDetails.Email);
            PasswordTextBox.SendKeys(TestData.LoginDetails.Password);
            LoginButton.Click();
        }
    }
}
