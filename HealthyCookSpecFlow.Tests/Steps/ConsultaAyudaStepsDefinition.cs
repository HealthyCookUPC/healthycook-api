using System;
using TechTalk.SpecFlow;

namespace HealthyCookSpecFlow.Tests.Steps
{
    [Binding]
    public class ConsultaAyudaStepsDefinition
    {
        [Given(@"the user wants to ask for help")]
        public void GivenTheUserWantsToAskForHelp()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user fills in the form with the requested information")]
        public void WhenTheUserFillsInTheFormWithTheRequestedInformation(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the user will get an answer")]
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
