using System;

namespace Lab1Adapter.Game
{
    public class Dice : IGame
    {
        private readonly Random _random;

        public Dice()
        {
            _random = new Random();
        }

        public int Roll()
        {
            return _random.Next(6) + 1;
        }
    }
}