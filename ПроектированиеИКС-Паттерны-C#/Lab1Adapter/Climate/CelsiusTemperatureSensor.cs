using System;

namespace Lab1Adapter.Climate
{
    public class CelsiusTemperatureSensor : ITemperatureSensor
    {
        private readonly Random _random;

        public CelsiusTemperatureSensor()
        {
            _random = new Random();
        }

        public double Measure()
        {
            return Math.Round(_random.NextDouble() * 100, 1, MidpointRounding.ToEven);
        }
    }
}