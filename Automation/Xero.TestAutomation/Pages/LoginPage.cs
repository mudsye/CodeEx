using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Xero.TestAutomation.Pages
{
    /// <summary>
    /// Page object model for Login screen
    /// </summary>
    public class LoginPage : PageBase
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        public IWebElement UsernameTextBox
        {
            get { return this.Find(By.Id("email")); }
        }

        public IWebElement PasswordTextBox
        {
            get { return this.Find(By.Id("password")); }
        }
        public IWebElement LoginButton
        {
            get { return this.Find(By.Id("submitButton")); }
        }
    }
}
