# CodeEx
# This is test automation solution to test very basic scenario for Xero i.e. to add an “ANZ (NZ)” bank account inside any Xero Organisation.
In order to run this get the code locally and run test using Test Explorer in Visual Studio 2017 (Enterprise).
Pre-reuisite: 
1. An account registered with Xero in New Zealand region when you add the organisation.
2. Before running the test in .\CodeEx\Automation\Xero.TestAutomation\TestData\TestData.json file update your registered email and password as below
{
  "LoginDetails": {
    "Email": "registered_email_id",
    "Password": "registered_password"
  }
}
