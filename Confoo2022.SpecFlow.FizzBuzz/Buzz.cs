namespace Confoo2022.SpecFlow.FizzBuzz
{
    class Buzz : Handler
    {
        public override string? Print(int i)
        {
            return (i % 5 == 0)
                ? "Buzz"
                : Next?.Print(i);
        }
    }
}
