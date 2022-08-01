using FluentAssertions.Execution;
using SpecFlowProject1.pageObjects;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly CalculatorPage _calculatorPage;

        public CalculatorStepDefinitions(CalculatorPage calculatorPage)
        {
            _calculatorPage = calculatorPage;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(string number)
        {
            _calculatorPage.EnterFirstNumber(number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(string number)
        {
            _calculatorPage.EnterSecondNumber(number);
        }

        [Given(@"I reset the calculator")]

        public void WhenIResetTheCalculator()
        {
            _calculatorPage.ClickReset();
        }

        [When("the two numbers are added")]
        public void WhenTwoNumbersAreaAdded()
        {
            _calculatorPage.ClickAdd();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultsShouldBe(string result)
        {
            var actualResult = _calculatorPage.WaitForNonEmptyResult();
            
            actualResult.Should().Be(result);   
        }

        [Then(@"all the fields should be cleared")]
        public void ThenAllTheFieldsShouldBeCleared()
        {
            using (new AssertionScope())
            {
                _calculatorPage.FirstNumberIsEmpty().Should().Be(true);
                _calculatorPage.SecondNumberIsEmpty().Should().Be(true);
                _calculatorPage.ResultIsEmpty().Should().Be(true);
            }

        }

    }
}