Feature: ConsultaAyuda
	As a user I would like to create a request for help

@registerUser
Scenario: The user gets an answer in the help window
	Given the user wants to ask for help
	When the user fills in the form with the requested information
	| Username   | Email               | Description        |
	| Pedrito007 | pedrito01@gmail.com | pedrito is a good person | 
	Then the user will get an answer

Scenario: The user can not get an answer in the help window
	Given the user wants to ask for help
	When the user fills in the form with the requested information
	Then a warning message will be displayed in the help window
	| Warning Message              |
	| Información no encontrada | 
