using System;

namespace Lab9Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var calculator = new Calculator();
            
            var result = calculator.Add(5);
            Console.WriteLine(result);
            result = calculator.Multiply(6);
            Console.WriteLine(result);
            result = calculator.Div(3);
            Console.WriteLine(result);
            result = calculator.Redo();
            Console.WriteLine(result);
            result = calculator.Undo(1);
            Console.WriteLine(result);
        }
    }
}