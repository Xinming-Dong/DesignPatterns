using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VictorianSofa : Sofa
    {
        public bool HasLegs()
        {
            return true;
        }

        public string SitOn()
        {
            return "Sitting on a Victorian sofa.";
        }
    }
}
