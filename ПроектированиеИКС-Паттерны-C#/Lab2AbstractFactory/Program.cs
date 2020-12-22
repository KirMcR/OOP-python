using System;
using Lab2AbstractFactory.Factory;

namespace Lab2AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var fordCar = new FordFactory();
            var c1 = new Client(fordCar);
            Console.WriteLine("Max speed {0} is {1} km/hour", c1.Car.Name, c1.RunMaxSpeed());


            var audiCar = new AudiFactory();
            var c2 = new Client(audiCar);
            Console.WriteLine("Max speed {0} is {1}  km/hour {2}", c2.Car.Name, c2.RunMaxSpeed(), c2.Car.GetBodyType(c2.Body));
        }
    }
}