Feature: Add Bank Account
	As a Xero User,
    In order to manage my business successfully,
    I want to be able to add an “ANZ (NZ)” bank account inside any Xero Organisation.

@addbankaccount
Scenario: Add new Bank Account inside any Xero Organisation
	Given I login to any Xero Organisation
	And I navigate to Bank Accounts screen
	When I add an ANZ (NZ) bank account of type Everyday (day-to-day)
	Then the newly added Bank Account appears on Bank Account screen
