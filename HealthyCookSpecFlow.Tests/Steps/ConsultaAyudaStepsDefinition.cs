using System;
using TechTalk.SpecFlow;

namespace HealthyCookSpecFlow.Tests.Steps
{
    [Binding]
    public class ConsultaAyudaStepsDefinition
    {
        [Given(@"user is logged into the application")]
        public void GivenTheUserWantsToAskForHelp()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user goes to the navigation bar")]
        public void WhenTheUserFillsInTheFormWithTheRequestedInformation(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"An explanation of each section, frequently asked questions and a form to ask a question will then appear on the screen")]
        public void ThenTheUserWillBeSuccessfullyRegistered()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a warning message will be displayed in the help window")]
        public void ThenAWarningMessageWillBeDisplayedOnThePasswordInput(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
