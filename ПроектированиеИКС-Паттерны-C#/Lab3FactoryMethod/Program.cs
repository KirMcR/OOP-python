using System;

namespace Lab3FactoryMethod
{
    internal class Program
    {
        //фабричный метод позволяет выбирать экземпляр какого класса-наследника создавать 
        private static void Main(string[] args)
        {
            TransportCompany taxiCompany = new TaxiTransportCompany("Taxi Service");
            var taxi = taxiCompany.Create("Taxi", 1);
            Print(taxi, 15);

            TransportCompany shipCompany = new ShipTransportCompany("Shipping Service");
            taxi = shipCompany.Create("Shipment", 2);
            Print(taxi, 150);

            TransportCompany drunkDriverCompany = new DrunkDriverTransportCompany("Drunk Driver Service");//функция пьяный водитель
            taxi = drunkDriverCompany.Create("Drunk Driver", 3);

            Print(taxi, 100);
        }

        private static void Print(TransportService transportService, double distance)
        {
            Console.WriteLine("Transport company: {0}, distance: {1}, cost: {2}",
                transportService, distance, transportService.CostTransportation(distance));
        }
    }
}