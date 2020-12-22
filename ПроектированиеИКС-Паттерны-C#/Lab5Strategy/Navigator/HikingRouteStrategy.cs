namespace Lab5Strategy.Navigator
{
    internal class HikingRouteStrategy : RouteStategy
    {
        public HikingRouteStrategy() => Type = "Hiking route";

        public override string Build(string start, string finish)
        {
            return $"Your hiking route: Start in {start}, then go and you are in {finish}";
        }
    }
}