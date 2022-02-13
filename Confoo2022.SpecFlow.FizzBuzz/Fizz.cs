namespace Confoo2022.SpecFlow.FizzBuzz
{
    class Fizz : Handler
    {
        public override string? Print(int i)
        {
            return (i % 3 == 0)
                ? "Fizz"
                : Next?.Print(i);
        }
    }
}
