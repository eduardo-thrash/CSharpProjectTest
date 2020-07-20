Feature: SantoTomasUniversity
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@UITest
@Santo Tomas
Scenario: User Accesses to Santo Tomas University web page
	Given User has "Santo Tomas University" name
	When User accesses to "Santo Tomas University" web page
	Then User get "Santo Tomas University" current web page URL
