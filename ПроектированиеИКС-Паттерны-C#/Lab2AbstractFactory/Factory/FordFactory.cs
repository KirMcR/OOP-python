namespace Lab2AbstractFactory.Factory
{
    internal class FordFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new FordCar("Ford");
        }

        public override Engine CreateEngine()
        {
            return new FordEngine();
        }

        public override Body CreateBody()
        {
            return new FordBody();
        }
    }

    internal class FordCar : Car
    {
        public FordCar(string name)
        {
            Name = name;
        }

        public override int GetMaxSpeed(Engine engine)
        {
            return engine.MaxSpeed;
        }
    }

    internal class FordEngine : Engine
    {
        public FordEngine()
        {
            MaxSpeed = 220;
        }
    }

    internal class FordBody : Body
    {
        public FordBody()
        {
            BodyType = "Sedan";
        }
    }
}