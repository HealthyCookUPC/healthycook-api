Feature: SearchRecipeByCalories
	As a user I want to search recipies by calories.

@searchRecipeByCalories
Scenario: User searches recipes by calories
	Given that the user is in the calories filter section
	When the user goes to the search bar for calories
	Then will then be presented with recipies with a minimun number of calories
	| Name  | Description | Preparation
	| Snadwich de pollo | ideal para desayunos     | Se necesita hechar jamon, pavo y lechuga con mayonesa y mostaza
	| Taco        | Esta comida es perfecta para almuerzos    |Se necesita preparar con pan de maiz, carne molida, verduras y salsas especiales
Scenario: User searches recipes by calories but there are no recipies matched
	Given that the user is in the calories filter section
	When the user goes to the search bar for calories
	And there is no recipie matched
	Then the user will then be notified that there is no recipie matched.
	| Message                                               |
	| No hay ninguna receta que coincida | 