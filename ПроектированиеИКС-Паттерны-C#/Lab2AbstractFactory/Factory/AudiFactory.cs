namespace Lab2AbstractFactory.Factory
{
    /*в CarFactiry  были добавлены классы Createbody(класс, возврпащающий значение кузова автомобиля и класс Body , описывающий кузов, в Классе ПРограм 
     * был произведен вывод значения Body*/
    internal class AudiFactory : CarFactory
    {
        public override Engine CreateEngine()
        {
            return new AudiEngine();
        }

        public override Car CreateCar()
        {
            return new AudiCar("Audi");
        }

        public override Body CreateBody()
        {
            return new AudiBody();
        }
    }

    internal class AudiCar : Car
    {
        public AudiCar(string name)
        {
            Name = name;
        }

        public override int GetMaxSpeed(Engine engine)
        {
            return engine.MaxSpeed;
        }
    }

    internal class AudiEngine : Engine
    {
        public AudiEngine()
        {
            MaxSpeed = 200;
        }
    }

    internal class AudiBody : Body
    {
        public AudiBody()
        {
            BodyType = "Coupe";
        }
    }
}