using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IFurnitureFactory
    {
        public Sofa CreateSofa(string color, string material);

        public CoffeeTable CreateCoffeeTable();
    }
}
