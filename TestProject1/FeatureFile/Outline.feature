Feature: Registration

Scenario Outline: Register event with valid information

Given I am on the registration page
When I provide username <username>
When I provide email <email>
When I provide age <age>
When I register for event

Examples: 
| username | email         | age |
| Jack     | Jack@test.com | 21  |
| dan      | dan@test.com  | 40  |
| joe      | joe@test.com  | 34  |

