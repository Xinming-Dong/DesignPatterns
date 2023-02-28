using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VictorianCoffeeTable : CoffeeTable
    {
        public string PutCoffeeOn()
        {
            return "putting coffee on a Victorian coffee table.";
        }
    }
}
