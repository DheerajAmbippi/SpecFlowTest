using TechTalk.SpecFlow.Assist;

namespace SpecFlowBasic.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private int num1;
        private int num2;
        private int sum;
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            num1 = number;
            
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            num2 = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            sum = num1 + num2;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            sum.Should().Be(result);
        }

        [Then(@"the message should be ""([^""]*)""")]
        public void ThenTheMessageShouldBe(string thankyou)
        {
            Console.WriteLine(thankyou);
        }

        [Given(@": the input following numbers to calculater")]
        public void GivenTheInputAreGivenForCalculater(Table table)
        {
           var task = table.CreateSet<calculation>();
            foreach (var item in task)
            {
                Console.WriteLine($"the given number : {item.Numbers}");
            }
        }

        [Given(@"the operation need to flow")]
        public void GivenTheOperationNeedToFlow(Table table)
        {
            dynamic datas = table.CreateDynamicSet();

            foreach (var item in datas)
            {
                Console.WriteLine(item.Operations);
            }
        }

        [Then(@"the result should for Addition")]
        public void ThenTheResultShouldForAddition(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine($"Result : {data.Result} operation : {data.Operation}");
        }


    }

    public record calculation
    {
        public int Numbers { get; set; }
    }
}
