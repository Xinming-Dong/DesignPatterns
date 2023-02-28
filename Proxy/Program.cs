namespace Proxy
{
    public static class Go
    {
        static void Main()
        {
            var database = new DatabaseService();
            var proxy = new DatabaseProxy(database, 3);
            var check1 = proxy.CheckExistance("aaa");
            Console.WriteLine("Check result: " + check1 + "\n");
            var add1 = proxy.Add("data111");
            Console.WriteLine("Add result: " + add1 + "\n");
            var add2 = proxy.Add("data222");
            Console.WriteLine("Add result: " + add2 + "\n");
            var delete1 = proxy.Delete("data333");
            Console.WriteLine("Delete result: " + delete1 + "\n");
            var add3 = proxy.Add("data333");
            Console.WriteLine("Add result: " + add3 + "\n");
            var add4 = proxy.Add("data444");
            Console.WriteLine("Add result: " + add4 + "\n");
            var add5 = proxy.Add("data555");
            Console.WriteLine("Add result: " + add5 + "\n");
            var add6 = proxy.Add("data111");
            Console.WriteLine("Add result: " + add6 + "\n");
            var delete2 = proxy.Delete("data333");
            Console.WriteLine("Delete result: " + delete2 + "\n");
            Console.ReadKey();
        }
    }
}