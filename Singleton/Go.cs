using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Singleton
{
    public static class Go
    {
        static Lazy<LazyTypeCoin> lazy = null;

        static void Main()
        {
            // use static coin
            StaticCoin.AddMoreCoin();
            StaticCoin.DeductCoin();

            // use singleton coin
            var coin = Coin.Instance();
            coin.AddMoreCoin();
            coin.AddMoreCoin();
            coin.DeductCoin();

            // Pros & Cons
            // Singleton
            // Pros
            // Object oriented: we can treat it as an instance while static are just functions
            // Singleton can implement interfaces and derive it
            // Cons
            // Not thread-safe

            // Static
            // Pros
            // Maybe when things is not necessary to be an object, we can use static. Like Object Factories?
            // Cons
            // Not thread-safe

            // use Lazy<T>
            lazy = new Lazy<LazyTypeCoin>(() => {
                LazyTypeCoin lazyCoin = new LazyTypeCoin(Thread.CurrentThread.ManagedThreadId);
                return lazyCoin;
            });

            Thread[] threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                threads[i] = new Thread(ThreadProc);
                threads[i].Start();
            }

            foreach (Thread t in threads)
            {
                t.Join();
            }

            // How Lazy<T> makes initialization thread-safe?
            // Ways to protect the object after creation? Lock, others?

            Console.ReadKey();
        }

        static void ThreadProc()
        {
            LazyTypeCoin coin = lazy.Value;

            lock(coin)
            {
                coin.LastUsedBy = Thread.CurrentThread.ManagedThreadId;
                coin.AddMoreCoin();
                coin.AddMoreCoin();
                coin.DeductCoin();
                Console.WriteLine("Initialized by thread {0}; last used by thread {1}.",
                coin.InitializedBy, coin.LastUsedBy);
            }
        }
    }
}
