using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;
using UITestProject.Steps.UtilSteps;

namespace UITestProject.Steps.UniversitiesSteps
{
    [Binding]
    public class JaverianaUniversitySteps : HooksUITest
    {
        private readonly IWebDriver currentDriver;

        public JaverianaUniversitySteps()
        {
            currentDriver = driverController;
        }

        [When(@"User selects to ""(.*)"" section")]
        public void WhenUserSelectsToSection(string sectionName)
        {
            Thread.Sleep(3000);
            currentDriver.FindElement(By.XPath("//*[@id='linksA']/ul/li[10]/a/span")).Click();
        }
    }
}