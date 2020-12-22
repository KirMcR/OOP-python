using System;
using Lab6TemplateMethod.Drink;
using Lab6TemplateMethod.Math;

namespace Lab6TemplateMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            Console.Write("First = ");
            var first = int.Parse(Console.ReadLine());
            Console.Write("Last = ");
            var last = int.Parse(Console.ReadLine());
            Console.Write("Delta = ");
            var delta = int.Parse(Console.ReadLine());

            Progression arithmetic = new ArithmeticProgression(first, last, delta);
            arithmetic.TemplateMethod();

            Progression geom = new GeometricProgression(first, last, delta);
            geom.TemplateMethod();
            
            Console.WriteLine();*/

            //Drink
            var maj = new beautiful();
            maj.Make();
            
            Console.WriteLine();
            
            var poc = new bald();
            poc.Make();
            
        }
    }
}