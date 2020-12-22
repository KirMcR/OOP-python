namespace Lab5Strategy.Navigator
{
    internal class CarRouteStrategy : RouteStategy
    {
        public CarRouteStrategy() => Type = "Route on car";

        public override string ToString() => Type;

        public override string Build(string start, string finish)
        {
            return $"Your car route: Start in {start}, then go and you are in {finish}";
        }
    }
}