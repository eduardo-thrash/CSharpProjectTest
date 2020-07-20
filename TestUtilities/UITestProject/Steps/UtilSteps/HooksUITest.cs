using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace UITestProject.Steps.UtilSteps
{
    [Binding]
    public class HooksUITest
    {
        public static IWebDriver driverController;

        protected HooksUITest()
        {
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("//TODO: implement logic that has to run before executing each scenario \n");
            driverController = new ChromeDriver();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("\n //TODO: implement logic that has to run after executing each scenario");
            driverController.Dispose();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("Finish Test run \n");
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Start Test run \n");
        }

        [AfterStep]
        public static void AfterStep()
        {
            Console.WriteLine("");
        }

        [BeforeStep]
        public static void BeforeStep()
        {
            Console.WriteLine("");
        }
    }
}