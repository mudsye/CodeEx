using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xero.TestAutomation
{
    public static class AppConfig
    {
        public static string Browser { get { return System.Configuration.ConfigurationManager.AppSettings["Browser"]; } }
        public static string Url { get { return System.Configuration.ConfigurationManager.AppSettings["Url"]; } }
        public static string SeleniumDriverPath
        {
            get
            {
                var configuredPath = System.Configuration.ConfigurationManager.AppSettings["SeleniumDriverPath"];

                if (configuredPath.StartsWith("file://"))
                {
                    return configuredPath.Replace("file://", string.Empty).Trim();
                }

                var path = Path.Combine(Path.GetDirectoryName(typeof(AppConfig).Assembly.Location), "Drivers");
                return path;
                //return ;
            }
        }
        public static string TestDataPath { get { return System.Configuration.ConfigurationManager.AppSettings["TestDataPath"]; } }
    }
}
