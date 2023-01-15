using System;

namespace Singleton
{
    public class SimpleLazyInitCoin
    {
        private static volatile SimpleLazyInitCoin instance = null;
        private int coin;
        private static readonly int addMoreCoin = 10;
        private static readonly object mutex = new object();

        private SimpleLazyInitCoin()
        {
            this.coin = 0;
        }

        public static SimpleLazyInitCoin Instance
        {
            get
            {
                if (instance == null)
                {
                    lock(mutex)
                    {
                        if (instance == null)
                        {
                            instance = new SimpleLazyInitCoin();
                        }
                    }
                }
                return instance;
            }
        }

        public void AddMoreCoin()
        {
            coin += addMoreCoin;
            Console.WriteLine("[Simple Lazy Initialization Coin] Added coin, current coin: " + coin);
        }

        public void DeductCoin()
        {
            coin--;
            Console.WriteLine("[Simple Lazy Initialization Coin] deducted coin, current coin: " + coin);
        }
    }
}
