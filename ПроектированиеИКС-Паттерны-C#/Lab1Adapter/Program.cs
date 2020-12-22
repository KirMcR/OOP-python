using System;
using Lab1Adapter.Climate;
using Lab1Adapter.Game;

namespace Lab1Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Game
            var dice = new Dice();
            var gamer = new Gamer("Ducky");
            Console.WriteLine("{0} points dropped for {1} player",
                gamer.Start(dice), gamer.Name);

            var coin = new Coin();
            var coinAdapter = new GameAdapter(coin);
            Console.WriteLine("The coin showed \"{0}\" for {1} player",
                gamer.Start(coinAdapter), gamer.Name);

            Console.WriteLine();

            //Climate
            var system = new ClimateControlSystem("Dycky Control System");
            var ftSensor = new FahrenheitTemperatureSensor();
            var sensorAdapter = new TemperatureSensorAdapter(ftSensor);

            Console.WriteLine("{0}: temperature in celsius {1} C", system.Name, sensorAdapter.Measure());
        }
    }
}