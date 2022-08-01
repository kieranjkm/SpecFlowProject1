using SpecFlowProject1.pageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public sealed class Hooks
    {

        [BeforeScenario]
        public void BeforeScenario(CalculatorPage calculatorPage)
        {
            calculatorPage.Goto();
        }
    }
}
