Feature: SearchRecipeByName
	As a user I want to search recipes by name.

@searchRecipeByName
Scenario: User searches recipes by name
	Given that the user is in the name filter section
	When the user goes to the search bar for name
	Then will then be presented with recipies with the name selected
	| Name  | Description | Preparation
	| Snadwich de pollo | ideal para desayunos     | Se necesita hechar jamon, pavo y lechuga con mayonesa y mostaza
	| Taco        | Esta comida es perfecta para almuerzos    |Se necesita preparar con pan de maiz, carne molida, verduras y salsas especiales
Scenario: User searches recipes by name but there are no recipies matched
	Given that the user is in the name filter section
	When the user goes to the search bar for name
	And there is no recipie matched
	Then the user will then be notified that there is no recipie matched.
	| Message                                               |
	| No hay ninguna receta que coincida | 