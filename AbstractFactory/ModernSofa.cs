using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ModernSofa : Sofa
    {
        public bool HasLegs()
        {
            return false;
        }

        public string SitOn()
        {
            return "Sitting on a modern sofa.";
        }
    }
}
