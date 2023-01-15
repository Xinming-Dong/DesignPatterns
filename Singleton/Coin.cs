using System;

namespace Singleton
{
    /// <summary>
    /// A coin class using Singleton, not thread-safe.
    /// </summary>
    public class Coin
    {
        private int coin;
        private static Coin instance;
        private static readonly int addMoreCoin = 10;

        private Coin()
        {
            // private constructor to prevent anyone else from instantiating
            this.coin = 0;
        }

        public static Coin Instance()
        {
            return instance;
        }

        public int GetCoin() { return coin; }

        public void AddMoreCoin()
        {
            coin += addMoreCoin;
            Console.WriteLine("[Basic Coin] Added coin, current coin: " + coin);
        }

        public void DeductCoin()
        {
            coin--;
            Console.WriteLine("[Basic Coin] deducted coin, current coin: " + coin);
        }
    }
}
