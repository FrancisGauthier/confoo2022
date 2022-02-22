using System;
using TechTalk.SpecFlow;

namespace Confoo2022.SpecFlow.Calculator.Specs.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly Calculator _calc = new ();
        private int _result;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            _calc.FirstNumber = p0;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            _calc.SecondNumber = p0;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calc.Add();
        }

        [When(@"the two numbers are substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            _result = _calc.Substract();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            _result.Should().Be(p0);
        }
    }
}
