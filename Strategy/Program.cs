namespace Strategy
{
    public static class Go
    {
        static void Main()
        {
            var tour = new TourStrategy();
            var walk = new WalkingStrategy();
            var road = new RoadStrategy();

            Console.WriteLine("Tour route");
            var navigator = new Navigator(5, tour);
            navigator.BuildRoute();

            Console.WriteLine("Walking route");
            navigator = new Navigator(6, walk);
            navigator.BuildRoute();

            Console.WriteLine("Road route");
            navigator = new Navigator(5, road);
            navigator.BuildRoute();
        }
    }
}