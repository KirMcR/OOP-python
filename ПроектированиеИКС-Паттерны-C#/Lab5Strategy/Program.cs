using System;
using Lab5Strategy.Navigator;
using Lab5Strategy.Sorting;

namespace Lab5Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr1 = {31, 15, 10, 2, 4, 2, 14, 23, 12, 66};
            SortStrategy sort = new Selection();
            var context = new Context(sort, arr1);

            context.Sort();
            context.PrintArray();

            int[] arr2 = {1, 5, 10, 2, 4, 12, 14, 23, 12, 66};
            sort = new Insertion();
            context = new Context(sort, arr2);
            context.Sort();
            context.PrintArray();


            int[] arr3 = {31, 15, 10, 2, 4, 2, 14, 23, 12, 66};
            sort = new Bubble();
            context = new Context(sort, arr3);

            context.Sort();
            context.PrintArray();

            Console.WriteLine();
            
            var start = "Home";
            var finish = "Coffee";

            var route1 = new HikingRouteStrategy();
            var route2 = new PublicTransportRouteStrategy();

            var navigator = new NavigatorApp(route1, "Ducky City");
            Console.WriteLine(navigator.BuildRoute(start, finish));

            navigator = new NavigatorApp(route2, "New Ducky City");
            Console.WriteLine(navigator.BuildRoute(start, finish));
        }
    }
}