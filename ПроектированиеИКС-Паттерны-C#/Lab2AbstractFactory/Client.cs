using Lab2AbstractFactory.Factory;

namespace Lab2AbstractFactory
{
    internal class Client
    {
        public Client(CarFactory carFactory)
        {
            Car = carFactory.CreateCar();
            Engine = carFactory.CreateEngine();
            Body = carFactory.CreateBody();
        }

        public Car Car { get; }
        public Engine Engine { get; }
        public Body Body { get; }

        public int RunMaxSpeed()
        {
            return Car.GetMaxSpeed(Engine);
        }

        public string GetBodyType()
        {
            return Car.GetBodyType(Body);
        }

        public override string ToString()
        {
            return Car.ToString();
        }
    }
}