using System;
using TechTalk.SpecFlow;

namespace UITestProject.Steps.UniversitiesSteps
{
    [Binding]
    public class SantoTomasUniversitySteps
    {
        [Given(@"User has ""(.*)"" name")]
        public void GivenUserHasName(string universityName)
        {
            Console.WriteLine($"Step description with {universityName} test.");
        }

        [When(@"User accesses to ""(.*)"" web page")]
        public void WhenUserAccessesToWebPage(string universityName)
        {
            Console.WriteLine($"Step description with {universityName} test.");
        }

        [Then(@"User get ""(.*)"" current web page URL")]
        public void ThenUserGetCurrentWebPageURL(string universityName)
        {
            Console.WriteLine($"Step description with {universityName} test.");
        }
    }
}