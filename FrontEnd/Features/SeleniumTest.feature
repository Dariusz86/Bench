﻿Feature: SeleniumTest


@mytag
Scenario: Verify elements on main page
Given I start Chrome browser
	When I navigate to http://gofortesting.gft.com/#/menu
	And I navigate to http://gofortesting.gft.com/#/table-list
	#And I verify existence of elements on page
	And I fill the form
Then I close browser
