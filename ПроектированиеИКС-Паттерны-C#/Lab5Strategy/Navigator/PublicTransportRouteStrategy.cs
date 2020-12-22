namespace Lab5Strategy.Navigator
{
    internal class PublicTransportRouteStrategy : RouteStategy
    {
        public PublicTransportRouteStrategy() => Type = "Public transport route";

        public override string ToString() => Type;

        public override string Build(string start, string finish)
        {
            return $"Your public transport route: Start in {start}, then go and you are in {finish}";
        }
    }
}