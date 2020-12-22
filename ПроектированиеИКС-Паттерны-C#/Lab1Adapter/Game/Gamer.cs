namespace Lab1Adapter.Game
{
    public class Gamer
    {
        public Gamer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int Start(IGame game)
        {
            return game.Roll();
        }
    }
}