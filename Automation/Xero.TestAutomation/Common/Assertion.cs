using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Xero.TestAutomation.Common
{
    public static class Assertion
    {
        public static void AssertContains(string expectedSubstrings1, string expectedString2, IReadOnlyCollection<IWebElement> BankAccountDetail, StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            bool results = false;
            foreach (IWebElement element in BankAccountDetail)
            {
                if (AssertContains(expectedSubstrings1, element.Text.ToString(), comparisonType) &&
                    AssertContains(expectedString2, element.Text.ToString(), comparisonType))
                {
                    results = true;
                    break;
                }
            }
            Assert.IsTrue(results, $"Account Name {expectedSubstrings1} and Account Number {expectedString2} does not exist");
        }

        public static bool AssertContains(string expectedSubstring, string actualString, StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            if (actualString == null || actualString.IndexOf(expectedSubstring, comparisonType) < 0)
                return false;
            return true;
        }
    }
}
