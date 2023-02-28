using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public CoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }

        public Sofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
