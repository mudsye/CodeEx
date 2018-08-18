using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xero.TestAutomation.DataStructures
{
    /// <summary>
    /// Object to load LoginDetails from TestData.json file
    /// </summary>
    public class LoginDetails
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
