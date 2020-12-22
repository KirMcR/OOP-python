namespace Lab3FactoryMethod
{
    internal abstract class TransportCompany
    {
        public string Name { get; set; }
        
        protected TransportCompany(string name) => Name = name;
        
        public override string ToString() => Name; 
        //Fabrich method
        public abstract TransportService Create(string name, int category);
    }

    internal class TaxiTransportCompany : TransportCompany
    {
        public TaxiTransportCompany(string name) : base(name)
        {
        }

        public override TransportService Create(string name, int category)
        {
            return new TaxiServices(name, category);
        }
    }

    internal class ShipTransportCompany : TransportCompany
    {
        public ShipTransportCompany(string name) : base(name)
        {
        }

        public override TransportService Create(string name, int category)
        {
            return new Shipping(name, category);
        }
    }

    internal class DrunkDriverTransportCompany : TransportCompany
    {
        public DrunkDriverTransportCompany(string name) : base(name)
        {
        }

        public override TransportService Create(string name, int category)
        {
            return new Shipping(name, category);
        }
    }
}