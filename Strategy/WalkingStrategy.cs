namespace Strategy
{
    public class WalkingStrategy : IRouteStrategy
    {
        public void BuildRoute(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j) Console.Write("O ");
                    else Console.Write("- ");
                }
                Console.Write("\n");
            }
        }
    }
}
