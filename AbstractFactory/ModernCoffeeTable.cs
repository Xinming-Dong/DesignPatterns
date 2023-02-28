using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ModernCoffeeTable : CoffeeTable
    {
        public string PutCoffeeOn()
        {
            return "putting coffee on a modern coffee table.";
        }
    }
}
