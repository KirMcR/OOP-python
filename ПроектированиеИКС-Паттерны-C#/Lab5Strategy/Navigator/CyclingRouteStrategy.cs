namespace Lab5Strategy.Navigator
{
    internal class CyclingRouteStrategy : RouteStategy
    {
        public CyclingRouteStrategy() => Type = "Cycling route";

        public override string ToString() => Type;

        public override string Build(string start, string finish)
        {
            return $"Your car route: Start in {start}, then go and you are in {finish}";
        }
    }
}