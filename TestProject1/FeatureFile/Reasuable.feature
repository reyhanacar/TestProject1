Feature: Reasuable

A short summary of the feature

@tag1
Scenario: Login with different user
	Given User navigate to url "<url>"
	When User enter texts "standart user" in "admin.txtUsername"
	When  User enter texts " secret_sauce" in "admin.txtPasword"
	When User click on "admin.login"
