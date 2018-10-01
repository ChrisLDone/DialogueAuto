using System;
using TechTalk.SpecFlow;

namespace SpecflowDialogue
{
    [Binding]
    public class SampleSteps
    {
        [Given(@"I have gone to bbc")]
        public void GivenIHaveGoneToBbc()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The Home Page Loads")]
        public void WhenTheHomePageLoads()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The Sport Link appears")]
        public void ThenTheSportLinkAppears()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
