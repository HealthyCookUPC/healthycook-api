Feature: Followers
	As a user I would like to follow a user on the web

@followUser
Scenario:Get followers that follow a user
	Given the user is logged into the application
	When the user makes click on the follow button
	Then a view with all followers will be displayed

Scenario:Get followeds by user
	Given the user is logged into the application
	When the user makes click on the followeds button
	Then a view with all followeds will be displayed

Scenario:Get followers that follow a user
	Given the user is logged into the application
	When the user makes click on follow button
	Then a view with all followers will be displayed

Scenario:Get numbers of followers by user
	Given the user is logged into the application
	When the user goes to the profile view 
	Then the user will see the number of followers
