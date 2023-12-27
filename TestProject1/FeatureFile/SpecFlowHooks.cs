using System.Security.Cryptography.X509Certificates;
using TechTalk.SpecFlow;

namespace TestProject1
{
    [Binding]
    public sealed class SpecFlowHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("This will be executed  before executing any of the code");

        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("This will be called at the end of execution.This will help to clean up the memory after execution");

        }
        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("This will be executed only once for feature file.");

        }

        [AfterFeature]

        public static void AfterFeature()
        {
            Console.WriteLine("This will be executed at the end of the feature file");

        }

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("This will be executed before executing the scenario");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
        }

            [AfterScenario]
            static void AfterScenario()
            {
                Console.WriteLine("This will be executed after executing the scenario");

            }
        [BeforeStep]
        public void BeforeStep()
        {
            Console.WriteLine("This will be executed steps");
        }
        [AfterStep]

        public void AfterStep()
        {
            Console.WriteLine("This will execute after step");
        }

        
    }
}
