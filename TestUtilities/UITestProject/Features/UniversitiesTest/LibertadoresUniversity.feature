Feature: LibertadoresUniversity
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@UITest
@Libertadores
Scenario: User Accesses to Libertadores University web page
	Given User has "Libertadores University" name
	When User accesses to "Libertadores University" web page "https://www.ulibertadores.edu.co/"
	Then User get "Libertadores University" current web page URL "https://www.ulibertadores.edu.co/"
