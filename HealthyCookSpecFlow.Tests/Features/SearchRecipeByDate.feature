Feature: FilterRecipesByDateV3
  As a user, I want to filter recipes by date to find recipes within a specified date range.

  @filterRecipesByDate
  Scenario: User filters recipes by a specific date range
    Given the user selects a start date "2023-01-01"
    And the user selects an end date "2023-09-27"
    When the user presses the button "Filter Recipes"
    Then a list of recipes created between the selected dates should be displayed
    | Recipe ID | Recipe Name       | Description                                |
    | 1         | Spaghetti Carbonara | Classic Italian pasta dish with eggs and bacon |
    | 2         | Chicken Stir-Fry  | Delicious chicken stir-fry recipe with vegetables |
    | 3         | Chocolate Cake    | Rich and moist chocolate cake recipe       |

  Scenario: User selects a start date but not an end date
    Given the user selects a start date "2023-05-01"
    When the user presses the button "Filter Recipes"
    Then a message should be displayed
    | Message                                   |
    | Please select both start and end dates    |

  Scenario: User selects an end date but not a start date
    Given the user selects an end date "2023-08-15"
    When the user presses the button "Filter Recipes"
    Then a message should be displayed
    | Message                                   |
    | Please select both start and end dates    |

  Scenario: User selects an end date earlier than the start date
    Given the user selects a start date "2023-09-15"
    And the user selects an end date "2023-09-10"
    When the user presses the button "Filter Recipes"
    Then a message should be displayed
    | Message                                   |
    | End date cannot be earlier than start date |

  Scenario: User selects a date range with no matching recipes
    Given the user selects a start date "2023-01-01"
    And the user selects an end date "2023-02-01"
    When the user presses the button "Filter Recipes"
    Then a message should be displayed
    | Message                                   |
    | No recipes found within the selected date range |
