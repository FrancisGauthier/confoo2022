namespace Confoo2022.SpecFlow.Calculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add() => FirstNumber + SecondNumber;
    }
}
