namespace Lab3FactoryMethod
{
    internal abstract class TransportService
    {
        public string Name { get; set; }

        protected TransportService(string name) => Name = name;

        public abstract double CostTransportation(double distance);
    }

    internal class TaxiServices : TransportService
    {
        public int Category { get; set; }

        public TaxiServices(string name, int category) : base(name)
        {
            Category = category;
        }

        public override double CostTransportation(double distance)
        {
            return distance * Category;
        }

        public override string ToString()
        {
            return $"Firm {Name}, trip category is {Category}";
        }
    }

    internal class Shipping : TransportService
    {
        public Shipping(string name, int taff) : base(name)
        {
            Tariff = taff;
        }

        public double Tariff { get; set; }

        public override double CostTransportation(double distance)
        {
            return distance * Tariff;
        }

        public override string ToString()
        {
            return $"Firm {Name}, tariff is {Tariff}";
        }
    }
    /*была добавлена функция пьяный водитель*/
    internal class DrunkDriverService : TransportService
    {
        public double Cost { get; set; }

        public DrunkDriverService(string name, int cost) : base(name)
        {
            Cost = cost;
        }

        public override double CostTransportation(double distance)
        {
            return Cost * distance;
        }

        public override string ToString()
        {
            return $"Firm {Name}, Service > Drunk driver";
        }
    }
}