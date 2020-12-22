namespace Lab5Strategy.Navigator
{
    internal class SightseeingRouteStrategy : RouteStategy
    {
        public SightseeingRouteStrategy() => Type = "Sightseeing route";

        public override string ToString() => Type;

        public override string Build(string start, string finish)
        {
            return $"Your sightseeing route: Start in {start}, then go and you are in {finish}";
        }
    }
}