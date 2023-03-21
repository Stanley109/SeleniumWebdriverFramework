Feature: Freshworks Tests

Background: Background name

Scenario: TC01: Add two numbers
    Given I have 1 and 2
	When i add both of them
	Then the result should be 3

Scenario: TC02: Verify that About us page displays the correct About us text banner
	Given I am in the Freshworks homepage
	When I click the about button under the Resources banner
	Then I should be redirected to the Freshworks About us page
	And I should see the About us banner paragraph text displayed correctly
		| paragraph |Freshworks makes it fast and easy for businesses to delight their customers and employees. We do this by taking a fresh approach to building and delivering software-as-a-service that’s affordable, quick to implement, and designed for the end-user. Unlike legacy software, Freshworks builds tech that works for everyone, making it easy for IT, customer service, sales, marketers and HR to do their job and delight their customers.|
