Feature: loginUser
	As a user I would like to login within the application
@loginUser
Scenario: The user is successfully logined
	Given the user wants to login
	And goes to the login window
	When the user fills in the window with the information requested
	| Username   | Password |
	| Pedrito007 | password123     | 
	Then the user will be successfully logined

Scenario: The user does not confirm his password
	Given the user wants to login
	When the user does not successfully confirm his password
	Then a warning message will be displayed on the password input
	| Warning Message              |
	| Las contraseñas no coinciden | 

Scenario: The user's email is already in use
	Given the user enters his email address
	And it is already in use by another user
	Then you will not be able to login and a message will be displayed
	| Message                                   |
	| El email ingresado ya se encuentra en uso | 