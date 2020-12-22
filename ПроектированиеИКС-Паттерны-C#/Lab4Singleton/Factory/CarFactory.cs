namespace Lab4Singleton.Factory
{
    internal abstract class CarFactory
    {
        public abstract Car CreateCar();
        public abstract Engine CreateEngine();
        public abstract Body CreateBody();
    }

    internal abstract class Car
    {
        public string Name { get; set; }
        public abstract int MaxSpeed(Engine engine);

        public string BodyType(Body body) => body.BodyType;
    }

    internal abstract class Engine
    {
        public int MaxSpeed { get; set; }
    }

    internal abstract class Body
    {
        public string BodyType { get; set; }
    }
}