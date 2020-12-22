namespace Lab10Decorator
{
    internal class SystemSecurity : DecoratorOptions
    {
        public SystemSecurity(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Enhanced security";
            Description = p.Description + ". " + Title + ". Front gear and side" +
                          "airbags, ESP - vehicle dynamic stabilization system";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 20.99;
        }
    }

    internal class MediaNAV : DecoratorOptions
    {
        public MediaNAV(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Modern";
            Description = p.Description + ". " + Title + ". Updated multimedia" +
                          " navigation system";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 20.99;
        }
    }

    internal class AutoPilotSystem : DecoratorOptions
    {
        public AutoPilotSystem(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Autopilot.";
            Description = p.Description + ". " + Title + ". Artificial intelligence drives the machine";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 1000;
        }
    }

    internal class TrackingSystem : DecoratorOptions
    {
        public TrackingSystem(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Tracking with cameras.";
            Description = p.Description + ". " + Title + ". 4 high-tech cameras with bluetooth option";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 100;
        }
    }
}