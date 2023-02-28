namespace Strategy
{
    public class Navigator
    {
        private readonly int size;
        private readonly IRouteStrategy routeStrategy;
        public Navigator(int size, IRouteStrategy routeStrategy)
        {
            this.size = size;
            this.routeStrategy = routeStrategy;
        }

        public void BuildRoute()
        {
            this.routeStrategy.BuildRoute(size);
        }
    }
}
