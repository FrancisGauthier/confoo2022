using Confoo2022.SpecFlow.FizzBuzz;
using System;
using TechTalk.SpecFlow;

namespace Confoo2022.SpefFlow.FizzBuzz.Specs.StepDefinitions
{
    [Binding]
    public class FizzBuzzStepDefinitions
    {
        Printer Printer = new Printer();
        string? Result = String.Empty;
        int _input;
        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(int p0)
        {
            _input = p0;
        }

        [When(@"I print the result")]
        public void WhenIPrintTheResult()
        {
            Result = Printer.Print(_input);
        }

        [Then(@"(.*) should be printed")]
        public void ThenShouldBePrinted(string p0)
        {
            Result.Should().Be(p0);
        }
    }
}
