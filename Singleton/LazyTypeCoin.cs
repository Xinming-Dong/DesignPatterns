using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class LazyTypeCoin
    {
        private int coin;
        private int initBy;
        private int lastUsedThread;

        public int InitializedBy { get { return initBy; } }
        public int LastUsedBy { 
            get { return lastUsedThread; }
            set { lastUsedThread = value; }
        }

        public LazyTypeCoin(int initBy)
        {
            this.coin = 0;
            this.initBy = initBy;
            this.lastUsedThread = -1;
        }

        public void AddMoreCoin()
        {
            coin ++;
            Console.WriteLine("[Lazy Type Coin] Added coin, current coin: " + coin);
        }

        public void DeductCoin()
        {
            coin--;
            Console.WriteLine("[Lazy Type Coin] deducted coin, current coin: " + coin);
        }
    }
}
