Feature: Comentario
	As a user I would like to comment on the page

@registerUser
Scenario: The user gets a comment on the page
	Given the user is logged into the application
	When the user get the comment by id
	Then the comment will be shown on the page
