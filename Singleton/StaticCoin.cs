using System;

namespace Singleton
{
    /// <summary>
    /// A full static Coin class.
    /// </summary>
    public static class StaticCoin
    {
        private static int coin = 0;
        private static readonly int addMoreCoin = 10;

        public static int GetCoin() { return coin; }

        public static void AddMoreCoin()
        {
            coin += addMoreCoin;
            Console.WriteLine("[Static Coin] Added coin, current coin: " + coin);
        }

        public static void DeductCoin()
        {
            coin--;
            Console.WriteLine("[Static Coin] deducted coin, current coin: " + coin);
        }
    }
}
