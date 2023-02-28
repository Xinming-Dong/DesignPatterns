namespace AbstractFactory
{
    public static class Go
    {
        static void Main()
        {
            IFurnitureFactory factory;
            Console.WriteLine("Select style:");
            Console.WriteLine("1. Victorian  2. Modern");
            var key = Console.ReadKey();
            if (key.KeyChar == '1')
            {
                factory = new VictorianFurnitureFactory();
            }
            else if (key.KeyChar == '2')
            {
                factory = new ModernFurnitureFactory();
            }
            else
            {
                Console.WriteLine("Invalid input");
                return;
            }
            var company = new FurnitureCompany(factory);
            company.CreateFurnitures();
            company.TryFurnitures();
        }

        // Sofa: VictorianSofa, ModernSofa
        // CoffeeTable: VictorianCoffeeTable, ModernCoffeeTable
        // FurnitureFactory:
        // + CreateSofa()
        // + CreateCoffeeTable()

        // FurnitureCompany
        // - IFurnitureFactory factory
        // - Sofa sofa
        // - CoffeeTable table
        // + CreateFurnitures()
        // + TryFurnitures()

        // What if some of the furniture doesn't have a specific style?
        // For example, the company can't produce a modern sofa
        // Or a more complex situation
        // Sofa: Victorian, Mediterranean
        // CoffeeTable: Modern, Victorian, European
        // Throw an exception?
        // Emun
        // Modern

        // multi-dimensional features?
        // For Example, in addition to styles, we can choose material
        // DinningTable/CoffeeTable
        // Victorian/ Modern
        // Wood/Glass
        // wood modern dinning table
    }
}