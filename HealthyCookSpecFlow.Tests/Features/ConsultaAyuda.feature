Feature: ConsultaAyuda
	As a user I would like to create a request for help

@registerUser
Scenario: The user gets an answer in the help window
	Given the user is logged into the application
	When the user goes to the navigation bar and press on the Help part
	| Username   | Email               | Description        |
	| Pedrito007 | pedrito01@gmail.com | pedrito is a good person | 
	Then An explanation of each section, frequently asked questions and a form to ask a question will then appear on the screen

Scenario: The user can not get an answer in the help window
	Given the user is logged into the application
	When the user goes to the navigation bar and press on the Help part
	Then a warning message will be displayed in the help window
	| Warning Message              |
	| Información no encontrada | 

	Scenario: The user can filter the table by priority and flag
	Given the user is logged into the application
	When the user can filter the table by priority and flag
	Then the information will be shown on the page
