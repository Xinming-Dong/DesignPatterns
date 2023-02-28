using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods
{
    public class SummerCalculator : Calculator
    {
        public override Operator CreateOperator()
        {
            return new Summer();
        }
    }
}
