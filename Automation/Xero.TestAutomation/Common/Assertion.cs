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
    /// <summary>
    /// Custom Assertion class
    /// </summary>
    public static class Assertion
    {
        /// <summary>
        /// Assertion on element Text property
        /// </summary>
        /// <param name="expectedSubstrings1">expectedSubstrings1</param>
        /// <param name="expectedSubstrings2">expectedSubstrings2</param>
        /// <param name="elements">IWebElements to get Text property for expected values</param>
        /// <param name="comparisonType">String Comparison Type</param>
        public static void AssertContains(string expectedSubstrings1, string expectedSubstrings2, IReadOnlyCollection<IWebElement> elements, StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            bool results = false;
            foreach (IWebElement element in elements)
            {
                if (AssertContains(expectedSubstrings1, element.Text.ToString(), comparisonType) &&
                    AssertContains(expectedSubstrings2, element.Text.ToString(), comparisonType))
                {
                    results = true;
                    break;
                }
            }
            Assert.IsTrue(results, $"Account Name {expectedSubstrings1} and Account Number {expectedSubstrings2} does not exist");
        }

        public static bool AssertContains(string expectedSubstring, string actualString, StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            if (actualString == null || actualString.IndexOf(expectedSubstring, comparisonType) < 0)
                return false;
            return true;
        }
    }
}
