namespace Confoo2022.SpecFlow.FizzBuzz
{
    public class NullFizzBuzz : Handler
    {
        public override string? Print(int i)
        {
            return i.ToString();
        }
    }
}
