namespace Confoo2022.SpecFlow.FizzBuzz
{
    public class Printer
    {
        public Handler Handler { get; set; }
        public Printer()
        {
            Handler = new FizzBuzz();
            Handler.SetNext(new Fizz())
                .SetNext(new Buzz())
                .SetNext(new NullFizzBuzz());

        }

        public string? Print(int i)
        {
            return Handler.Print(i);
        }
    }
}
