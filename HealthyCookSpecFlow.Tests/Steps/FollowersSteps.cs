using System;
using TechTalk.SpecFlow;
namespace HealthyCookSpecFlow.Tests.Steps
{
    [Binding]
    public class FollowersFeatureSteps
    {
        [Given("the user is logged into the application")]
        public void GivenTheUserIsLoggedIn()
        {
           ScenarioContext.Current.Pending();
        }

        [When("the user makes click on the follow button")]
        public void WhenUserClicksFollowButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When("the user makes click on the followeds button")]
        public void WhenUserClicksFollowedsButton()
        {
           ScenarioContext.Current.Pending();
        }

        [When("the user goes to the profile view")]
        public void WhenUserGoesToProfileView()
        {
           ScenarioContext.Current.Pending();
        }

        [Then("a view with all followers will be displayed")]
        public void ThenViewWithFollowersDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

        [Then("a view with all followeds will be displayed")]
        public void ThenViewWithFollowedsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

        [Then("the user will see the number of followers")]
        public void ThenUserSeesNumberOfFollowers()
        {
            ScenarioContext.Current.Pending();
        }
    }
}