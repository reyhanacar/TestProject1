Feature: Login


Scenario: Login with valid credantials
Given I am on the login page
When I enter username
When I enter password
When I select login
Then I verify successfull login
