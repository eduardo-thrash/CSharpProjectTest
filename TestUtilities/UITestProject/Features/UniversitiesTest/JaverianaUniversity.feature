Feature: JaverianaUniversity
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@UITest
@Javeriana
Scenario: User Accesses to Javeriana University web page
	Given User has "Javeriana University" name
	When User accesses to "Javeriana University" web page "https://www.javeriana.edu.co/home"
	Then User get "Javeriana University" current web page URL "https://www.javeriana.edu.co/home"

@UITest
@Javeriana
Scenario: User Accesses to Donaciones section in Javeriana University web page
	Given User has "Javeriana University" name
	When User accesses to "Javeriana University" web page "https://www.javeriana.edu.co/home"
	And User selects to "Donaciones" section
	Then User get "Javeriana University" current web page URL "https://www.javeriana.edu.co/donaciones/"
