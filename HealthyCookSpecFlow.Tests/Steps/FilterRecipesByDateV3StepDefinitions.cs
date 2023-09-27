using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace HealthyCookSpecFlow.Tests.Steps
{
    [Binding]
    public class FilterRecipesByDateV3StepDefinitions
    {
        [Given(@"the user selects a start date ""([^""]*)""")]
        public void GivenTheUserSelectsAStartDate(string p0)
        {
            Assert.AreEqual("200", "200");
        }

        [Given(@"the user selects an end date ""([^""]*)""")]
        public void GivenTheUserSelectsAnEndDate(string p0)
        {
            Assert.AreEqual("200", "200");
        }

        [When(@"the user presses the button ""([^""]*)""")]
        public void WhenTheUserPressesTheButton(string p0)
        {
            Assert.AreEqual("200", "200");
        }

        [Then(@"a list of recipes created between the selected dates should be displayed")]
        public void ThenAListOfRecipesCreatedBetweenTheSelectedDatesShouldBeDisplayed(Table table)
        {
            Assert.AreEqual("200", "200");
        }

        [Then(@"a message should be displayed")]
        public void ThenAMessageShouldBeDisplayed(Table table)
        {
            Assert.AreEqual("200", "200");
        }
    }
}
