namespace Proxy
{
    public interface IDatabase
    {
        public bool Add(string data);

        public bool Delete(string data);

        public bool CheckExistance(string data);
    }
}
