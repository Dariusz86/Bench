Feature: PlayWithCalculator


@mytag
Scenario: Multiplication Example
Given I start Chrome browser
When I navigate to http://juliemr.github.io/protractor-demo/
	And I insert first value: 150
	And I insert second value: 20
	And I do multplication
Then I verify results
	And I close browser