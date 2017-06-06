Feature: Test1


@mytag
Scenario: Verify Data
Given table qa.Client has 304 rows
	When following row is present: Country = 'Poland' in following table qa.Client with amount of 150
		Then Verify Number Of Contacts for Clients

