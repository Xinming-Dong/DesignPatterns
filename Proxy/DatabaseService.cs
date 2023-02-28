namespace Proxy
{
    public class DatabaseService : IDatabase
    {
        /// <summary>
        /// data entries.
        /// Assume all data entries are unique.
        /// </summary>
        public List<string> DataEntries { get; set; }

        public DatabaseService() 
        {
            DataEntries = new List<string>();
        }

        public bool CheckExistance(string data)
        {
            Console.WriteLine("{ Database } is checking data: [" + data + "]");
            return DataEntries.Contains(data);
        }

        public bool Delete(string data)
        {
            Console.WriteLine("{ Database } is deleting data: [" + data + "]");
            return DataEntries.Remove(data);
        }

        public bool Add(string data)
        {
            Console.WriteLine("{ Database } is adding data: [" + data + "]");
            if (DataEntries.Contains(data))
            {
                Console.WriteLine("{ Database } data previously existed, adding failed");
                return false;
            }
            DataEntries.Add(data);
            return true;
        }
    }
}
