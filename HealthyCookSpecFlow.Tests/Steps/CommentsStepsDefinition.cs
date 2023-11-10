using System;
using TechTalk.SpecFlow;

namespace HealthyCookSpecFlow.Tests.Steps
{
    [Binding]
    public class CommentstepsDefinition
    {
        [Given(@"the user is logged into the application")]
        public void GivenTheUserIsLoggedIntoTheApplication()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"When the user get the comment by id")]
        public void WhenTheUserGetTheCommentById()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the comment will be shown on the page")]
        public void ThenTheCommentWillBeShownOnThePage()
        {
            ScenarioContext.Current.Pending();
        }
        
    }
}
