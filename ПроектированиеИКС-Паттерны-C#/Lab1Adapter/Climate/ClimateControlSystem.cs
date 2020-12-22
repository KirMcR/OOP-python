namespace Lab1Adapter.Climate
{
    public class ClimateControlSystem
    {
        public ClimateControlSystem(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public double Run(ITemperatureSensor temperatureSensor)
        {
            return temperatureSensor.Measure();
        }
    }
}