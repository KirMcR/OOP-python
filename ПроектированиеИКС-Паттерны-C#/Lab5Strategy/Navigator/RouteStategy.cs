namespace Lab5Strategy.Navigator
{//вклюяает общее свойство тип и метот построения пути
    internal abstract class RouteStategy
    {
        public string Type { get; set; }

        public abstract string Build(string start, string finish);
    }
}