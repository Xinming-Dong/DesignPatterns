namespace AbstractFactory
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public CoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }

        public Sofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
