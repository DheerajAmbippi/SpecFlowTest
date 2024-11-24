using TechTalk.SpecFlow;

namespace SpecFlowBasic.Hooks
{
    [Binding]
    public sealed class InitialTest
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        #region Feature
        [BeforeFeature]
        public static void BeforeFeature() => Console.WriteLine("Before Feature");
        #region Scenario

        [BeforeScenario("@mytag")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("Before Scenario With Tag @tag1");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            Console.WriteLine("Before Scenario for 1st order");
        }

        #region Step

        [BeforeStep]
        public  void BeforeStep() => Console.WriteLine(nameof(BeforeStep));

        #region TestRun

        [BeforeTestRun]
        public static void BeforeTestRun() => Console.WriteLine(nameof(BeforeTestRun));
        [AfterTestRun]
        public static void AfterTestRun() => Console.WriteLine(nameof(AfterTestRun));
        #endregion

        [AfterStep]
        public void AfterStep() => Console.WriteLine(nameof(AfterStep));

        #endregion

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("After Scenario");
        }
        #endregion

        [AfterFeature]
        public static void AfterFeature() => Console.WriteLine("After Feature");
        #endregion
    }
}