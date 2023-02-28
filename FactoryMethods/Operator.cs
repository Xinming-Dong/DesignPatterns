using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods
{
    public interface Operator
    {
        public int Operate(params int[] list);

        public string GetOperatorType();
    }
}
