Feature: Comentario
	As a user I would like to comment on the page

@registerUser
Scenario: The user gets a comment on the page
	Given the user is logged into the application
	When the user get the comment by id
	Then the comment will be shown on the page

Scenario: The user add a like to comments
Given the user is logged into the application
	When the user clicks the like button
	Then the comment will add a like
