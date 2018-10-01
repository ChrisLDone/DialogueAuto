using System;
using TechTalk.SpecFlow;

namespace Direct
{
    [Binding]
    public class AdditionalDriverClaimsAndConvictionsSteps
    {
        [Then(@"I select No to is this conviction for additional driver two still pending")]
        public void ThenISelectNoToIsThisConvictionForAdditionalDriverTwoStillPending()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter the date of the conviction for additional driver two as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ThenIEnterTheDateOfTheConvictionForAdditionalDriverTwoAs(int p0, string p1, int p2)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I select the type of conviction for additional driver two as ""(.*)""")]
        public void ThenISelectTheTypeOfConvictionForAdditionalDriverTwoAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter tne amount of penalty points for additional driver two as ""(.*)""")]
        public void ThenIEnterTneAmountOfPenaltyPointsForAdditionalDriverTwoAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
