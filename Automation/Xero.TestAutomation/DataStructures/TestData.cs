using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xero.TestAutomation.DataStructures
{
    /// <summary>
    /// Test data loaded in memory from the TestData.json file
    /// </summary>
    public class TestData
    {
        public LoginDetails LoginDetails { get; set; }

        public TestData() { }
        public TestData(string filePath)
        {
            string json = File.ReadAllText(filePath);

            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<TestData>(json);

            this.LoginDetails = data.LoginDetails;
        }
    }
}
