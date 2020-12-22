using System;

namespace Lab4Singleton.Factory
{
    internal class FordFactory : CarFactory
    {

        private FordFactory()
        {
        }

        public override Car CreateCar() => new FordCar("Ford");

        public override Engine CreateEngine() => new FordEngine();

        public override Body CreateBody() => new FordBody();
    }

    internal class FordCar : Car
    {
        public FordCar(string name) => Name = name;

        public override int MaxSpeed(Engine engine) => engine.MaxSpeed;

        public override string ToString() => "Car " + Name;
    }

    internal class FordEngine : Engine
    {
        public FordEngine() => MaxSpeed = 200;
    }

    internal class FordBody : Body
    {
        public FordBody() => BodyType = "Sedan";
    }
}