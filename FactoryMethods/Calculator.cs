using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods
{
    public abstract class Calculator
    {
        public abstract Operator CreateOperator();

        public void calculate()
        {
            Operator op = CreateOperator();
            var result = op.Operate(1, 2, 3, 4);
            Console.WriteLine("calculator: " + op.GetOperatorType());
            Console.WriteLine("result: " + result);
        }
    }
}
