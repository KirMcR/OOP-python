using System;

namespace Lab1Adapter.Climate
{
    public class TemperatureSensorAdapter : ITemperatureSensor//адаптер, который добавл€ет в программу возможность использовани€ шкалы цельси€
    /*т.к. наследуетс€ от ITemperatureSenso, который определ€ет метод Measure дл€ стандартного интерфейса, 
     * что позвол€ет реализовать свой метод  Measure, только уже возвращающий значени€ в ÷ельсии*/
    {
        private readonly FahrenheitTemperatureSensor _sensor;

        public TemperatureSensorAdapter(FahrenheitTemperatureSensor sensor)
        {
            _sensor = sensor;
        }

        public double Measure()
        {
            return Math.Round((_sensor.Measure() - 32) / 1.8, 1, MidpointRounding.ToEven);
        }
    }
}