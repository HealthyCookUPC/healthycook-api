using System;
using TechTalk.SpecFlow;

namespace HealthyCookSpecFlow.Tests.Steps
{
    [Binding]
    public class SearchRecipeByIngredientStepsDefinition
    {        
        [Given(@"that the user is in the Category filter section")]
        public void GivenTheUserIsInTheCategoryFilterSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user goes to the search bar for Category""(.*)""\.")]
        public void WhenTheUserGoesToTheSearchBarForCategory(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the user goes to the search bar for Category")]
        public void WhenTheUserGoesToTheSearchBarForCategory()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the user will then be presented with recipies with the Category selected")]
        public void ThenTheUserWillThenBePresentedWithRecipiesWithTheCategorySelected_(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the user will then be notified that there is no recipie matched.")]
        public void ThenTheUserWillThenBeNotifiedThatThereIsNoRecipieMatched(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [And(@"there is no recipie matched")]
        public void AndThereIsNoRecipieMatched(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the user will then be notified that there is no recipie matched.")]
        public void ThenTheUserWillThenBeNotifiedThatThereIsNoRecipieMatched(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
