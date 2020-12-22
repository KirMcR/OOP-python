using System;

namespace Lab4Singleton.Factory
{/*Для реализации техники отложенной инициализации в C# рекомендуется воспользоваться
классом Lazy<T>, причем по умолчанию экземпляры класса Lazy<T> являются
потокобезопасными  передача делегата конструктору, который вызывает конструктор Log,
которому передается лямбда-выражение)  в рещультате при потпытке создать новый экземпляр   AudiFactory при уже существующем - 
    вы просто вернете ссылку*/
    internal class AudiFactory : CarFactory

    {

        private static readonly Lazy<AudiFactory> audiFactory = new(() => new AudiFactory());

        public static AudiFactory GetAudiFactory => audiFactory.Value;
        
        public static AudiFactory Factory => audiFactory.Value;

        public override Engine CreateEngine() => new AudiEngine();

        public override Car CreateCar() => new AudiCar("Audi");

        public override Body CreateBody() => new AudiBody();
    }

    internal class AudiCar : Car
    {
        public AudiCar(string name) => Name = name;

        public override int MaxSpeed(Engine engine) => engine.MaxSpeed;

        public override string ToString() => "Car" + Name;
    }

    internal class AudiEngine : Engine
    {
        public AudiEngine() => MaxSpeed = 300;
    }

    internal class AudiBody : Body
    {
        public AudiBody()
        {
            BodyType = "Coupe";
        }
    }
}