namespace Lab1Adapter.Game
{
    public class GameAdapter : IGame
    {
        private readonly Coin _coin;

        public GameAdapter(Coin coin)
        {
            _coin = coin;
        }

        public int Roll()
        {
            return _coin.Toss();
        }
    }
}