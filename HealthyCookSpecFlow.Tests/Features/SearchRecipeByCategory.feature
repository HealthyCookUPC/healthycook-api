Feature: SearchRecipeByCategory
	As a user I want to search recipies by Category.

@searchRecipeByCategory
Scenario: User searches recipes by Category
	Given that the user is in the Category filter section
	When the user goes to the search bar for Category
	Then will then be presented with recipies with a minimun number of Category
	| Name  | Description | Preparation
	| Snadwich de pollo | ideal para desayunos     | Se necesita hechar jamon, pavo y lechuga con mayonesa y mostaza
	| Taco        | Esta comida es perfecta para almuerzos    |Se necesita preparar con pan de maiz, carne molida, verduras y salsas especiales
Scenario: User searches recipes by Category but there are no recipies matched
	Given that the user is in the Category filter section
	When the user goes to the search bar for Category
	And there is no recipie matched
	Then the user will then be notified that there is no recipie matched.
	| Message                                               |
	| No hay ninguna receta que coincida | 