using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods
{
    public class Summer : Operator
    {
        public int Operate(params int[] list)
        {
            int sum = 0;
            foreach (int i in list)
            {
                sum+= i;
            }

            return sum;
        }

        public string GetOperatorType()
        {
            return "summer";
        }
    }
}
