using System;

namespace Lab1Adapter.Climate
{
    public class FahrenheitTemperatureSensor
    {
        private readonly Random _random;

        public FahrenheitTemperatureSensor()
        {
            _random = new Random();
        }

        public double Measure()
        {
            return Math.Round(_random.NextDouble() * 100 + 32, 1, MidpointRounding.ToEven);
        }
    }
}