// See https://aka.ms/new-console-template for more information

using Confoo2022.SpecFlow.FizzBuzz;

var printer = new Printer();
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(printer.Print(i));
}

