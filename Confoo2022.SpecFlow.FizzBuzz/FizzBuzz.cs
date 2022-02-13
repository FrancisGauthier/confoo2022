namespace Confoo2022.SpecFlow.FizzBuzz
{
    class FizzBuzz : Handler
    {
        public override string? Print(int i)
        {
            return (i % 3 == 0 && i % 5 == 0)
                    ? "FizzBuzz"
                    : Next?.Print(i);
        }
    }
}
