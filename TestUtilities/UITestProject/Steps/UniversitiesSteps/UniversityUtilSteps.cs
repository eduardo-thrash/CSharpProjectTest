using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using UITestProject.Steps.UtilSteps;

namespace UITestProject.Steps.UniversitiesSteps
{
    [Binding]
    public class UniversityUtilSteps : HooksUITest
    {
        private readonly IWebDriver currentDriver;

        public UniversityUtilSteps()
        {
            currentDriver = driverController;
        }

        [Given(@"User has ""(.*)"" name")]
        public void GivenUserHasName(string universityName)
        {
            // Method intentionally left empty.
        }

        [When(@"User accesses to ""(.*)"" web page ""(.*)""")]
        public void WhenUserAccessesToWebPage(string universityName, string universityUrl)
        {
            currentDriver.Navigate().GoToUrl(universityUrl);
        }

        [Then(@"User get ""(.*)"" current web page URL ""(.*)""")]
        public void ThenUserGetCurrentWebPageURL(string p0, string universityUrl)
        {
            Assert.AreEqual(currentDriver.Url, universityUrl);
            currentDriver.Dispose();
        }
    }
}