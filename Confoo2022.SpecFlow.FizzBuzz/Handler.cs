namespace Confoo2022.SpecFlow.FizzBuzz
{
    public abstract class Handler
    {
        protected Handler Next { get; set; }
        public abstract string? Print(int i);

        public Handler SetNext(Handler h)
        {
            Next = h;
            return h;
        }
    }
}
