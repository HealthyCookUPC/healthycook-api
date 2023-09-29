using System;
using TechTalk.SpecFlow;

namespace HealthyCookSpecFlow.Tests.Steps
{
    [Binding]
    public class SearchRecipeByIngredientStepsDefinition
    {        
        [Given(@"that the user is in the Calory filter section")]
        public void GivenTheUserIsInTheCaloryFilterSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user goes to the search bar for Calory""(.*)""\.")]
        public void WhenTheUserGoesToTheSearchBarForCalory(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the user goes to the search bar for Calory")]
        public void WhenTheUserGoesToTheSearchBarForCalory()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the user will then be presented with recipies with the Calory selected")]
        public void ThenTheUserWillThenBePresentedWithRecipiesWithTheCalorySelected_(Table table)
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
