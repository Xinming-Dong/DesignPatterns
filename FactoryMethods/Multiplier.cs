using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods
{
    public class Multiplier : Operator
    {
        public int Operate(params int[] list)
        {
            int res = 1;
            foreach (int i in list)
            {
                res *= i;
            }

            return res;
        }

        public string GetOperatorType()
        {
            return "multiplier";
        }
    }
}
