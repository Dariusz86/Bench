Feature: CheckGmail

@mytag
Scenario: GoToGmail
	Given I start Chrome browser
	When I navigate to https://www.google.pl/webhp?complete=0
		And I type gmail in search box
		And I click search button
		And I click gmail link
		And I click SignIn
		And I write down email address
		And I click next