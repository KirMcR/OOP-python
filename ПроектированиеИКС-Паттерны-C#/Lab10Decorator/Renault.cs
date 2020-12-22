namespace Lab10Decorator
{
    internal class Renault : AutoBase
    {
        public Renault(string name, string info, double costbase)
        {
            Name = name;
            Description = info;
            CostBase = costbase;
        }

        public override double GetCost() => CostBase * 1.18;
    }
}