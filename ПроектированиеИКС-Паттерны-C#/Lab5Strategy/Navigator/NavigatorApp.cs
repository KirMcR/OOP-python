using System;

namespace Lab5Strategy.Navigator
{
    internal class NavigatorApp
    {
        public string City { get; }
        private readonly RouteStategy _strategy;
        //в конструкторе НavigatorApp при создании объекта выбирается и стратегия
        public NavigatorApp(RouteStategy strategy, string city)
        {
            _strategy = strategy;
            City = city;
        }

        public override string ToString() => _strategy + "in" + City;

        public string BuildRoute(string start, string finish)
        {
            return _strategy.Build(start, finish);
        }

        public void ShowMap()
        {
            Console.WriteLine("You are here in {0}", City);
        }

        public void FindPlace(string place)
        {
            Console.WriteLine("Your place {0} is here", place);
        }
    }
}