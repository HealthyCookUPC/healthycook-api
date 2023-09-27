Feature: SearchRecipeByDifficulty
	As a user I want to search recipies by difficulty.

@searchRecipeByDifficulty
Scenario: User searches recipes by difficulty
	Given that the user is in the difficulty filter section
	When the user goes to the search bar for difficulty
	Then will then be presented with recipies by difficulty
	| Name  | Description | Preparation
	| Snadwich de pollo | ideal para desayunos     | Se necesita hechar jamon, pavo y lechuga con mayonesa y mostaza
	| Taco        | Esta comida es perfecta para almuerzos    |Se necesita preparar con pan de maiz, carne molida, verduras y salsas especiales
Scenario: User searches recipes by difficulty but there are no recipies matched
	Given that the user is in the difficulty filter section
	When the user goes to the search bar for difficulty
	And there is no recipie matched
	Then the user will then be notified that there is no recipie matched.
	| Message                                               |
	| No hay ninguna receta que coincida | 