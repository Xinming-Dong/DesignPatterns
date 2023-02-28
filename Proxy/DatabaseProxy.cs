namespace Proxy
{
    public class DatabaseProxy : IDatabase
    {
        private readonly DatabaseService realDatabaseService;
        private readonly Dictionary<string, int> cache;
        private int operationCount;
        private readonly int maxCachedOperation;

        public DatabaseProxy(DatabaseService realDatabaseService, int maxCachedOperation)
        {
            this.realDatabaseService = realDatabaseService;
            this.cache = new Dictionary<string, int>();
            this.operationCount = 0;
            this.maxCachedOperation = maxCachedOperation;
        }

        public bool CheckExistance(string data)
        {
            this.operationCount++;
            var result = false;
            Console.WriteLine("{ Proxy } is checking data: [" + data + "]");
            if (this.cache.ContainsKey(data) || this.realDatabaseService.CheckExistance(data))
            {
                cache[data] = this.operationCount;
                result= true;
            }
            this.UpdateCache();
            return result;
        }

        public bool Delete(string data)
        {
            this.operationCount++;
            var result = false;
            Console.WriteLine("{ Proxy } is deleting data: [" + data + "]");
            if (this.cache.Remove(data))
            {
                Console.WriteLine("{ Proxy } found data in cache, deleting...");
                this.realDatabaseService.Delete(data);
                result = true;
            }
            else if (this.realDatabaseService.Delete(data))
            {
                Console.WriteLine("{ Proxy } Data not found in cache, reaching to database...");
                result= true;
            }
            this.UpdateCache();
            return result;
        }

        public bool Add(string data)
        {
            this.operationCount++;
            Console.WriteLine("{ Proxy } is adding data: [" + data + "]");
            var result = false;
            if (!this.cache.ContainsKey(data) && this.realDatabaseService.Add(data))
            {
                this.cache[data] = this.operationCount;
                result = true;
            }
            this.UpdateCache();
            return result;
        }

        private void UpdateCache()
        {
            Console.WriteLine("{ Proxy } is updating the cache. Current cache: ");
            foreach(var (k,v) in this.cache)
            {
                if (v < this.operationCount - maxCachedOperation)
                {
                    this.cache.Remove(k);
                    continue;
                }
                Console.WriteLine("data: [" + k + "], operation index: [" + v + "]");
            }
        }
    }
}
