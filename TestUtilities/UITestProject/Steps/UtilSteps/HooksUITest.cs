using System;
using TechTalk.SpecFlow;

namespace UITestProject.Steps.UtilSteps
{
    [Binding]
    public sealed class HooksUITest
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("//TODO: implement logic that has to run before executing each scenario \n");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("\n //TODO: implement logic that has to run after executing each scenario");
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
    }
}