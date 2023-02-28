namespace Strategy
{
    public class RoadStrategy : IRouteStrategy
    {
        public void BuildRoute(int size)
        {
            var mid = size / 2;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i == 0 && j < mid) || (j == mid) || (i == size-1 && j > mid)) Console.Write("O ");
                    else Console.Write("- ");
                }
                Console.Write("\n");
            }
        }
    }
}
