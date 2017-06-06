Feature: NavigateThroughPages 


@mytag
Scenario: GoThroughPages
Given I start Chrome browser
	#When I navigate to http://interia.pl
	#And I navigate to http://in4.pl
	When I navigate to http://juliemr.github.io/protractor-demo/
	And I make calculation
	Then I close browser