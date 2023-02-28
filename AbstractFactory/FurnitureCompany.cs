using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FurnitureCompany
    {
        private IFurnitureFactory factory;

        private Sofa sofa;

        private CoffeeTable table;

        public FurnitureCompany(IFurnitureFactory factory)
        {
            this.factory = factory;
        }

        public void CreateFurnitures()
        {
            this.sofa = factory.CreateSofa();
            this.table = factory.CreateCoffeeTable();
            // bool TryCreateSofa(out sofa)
        }

        //CanCreate(Enum style)

        public void TryFurnitures()
        {
            Console.WriteLine(this.sofa.SitOn());
            Console.WriteLine("This sofa " + (this.sofa.HasLegs() ? "has" : "doesn't has") + " legs.");
            Console.WriteLine(this.table.PutCoffeeOn());
        }

        // Create sofa order
        // create multiple instances of objects at run time
    }
}
