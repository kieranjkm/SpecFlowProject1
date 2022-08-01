Feature: Calculator

Scenario Outline: Adding 2 numbers in the calculator
	Given the first number is <First number>
	And the second number is <Second number>
	When the two numbers are added
	Then the result should be <Expected result>

Examples:
	| First number | Second number | Expected result |
	| 50           | 70            | 120             |
	| -1           | 10            | 9               |
	| 6            | 9             | 15              |


Scenario: Reset button clears all fields
	Given I reset the calculator
	Then all the fields should be cleared


