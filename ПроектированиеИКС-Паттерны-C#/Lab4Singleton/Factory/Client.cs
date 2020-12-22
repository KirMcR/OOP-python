namespace Lab4Singleton.Factory
{
    internal class Client
    {
        private readonly Body _body;
        private readonly Car _car;
        private readonly Engine _engine;

        public Client(CarFactory carFactory)
        {
            _car = carFactory.CreateCar();
            _engine = carFactory.CreateEngine();
            _body = carFactory.CreateBody();
        }

        public int GetMaxSpeed()
        {
            return _car.MaxSpeed(_engine);
        }

        public string GetBodyType()
        {
            return _car.BodyType(_body);
        }

        public override string ToString()
        {
            return _car.ToString();
        }
    }
}