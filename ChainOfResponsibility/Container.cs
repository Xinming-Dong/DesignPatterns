using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Container : Component
    {
        protected List<Component> children;

        public Container()
        {
            this.children = new List<Component>();
        }

        public void Add(Component c)
        {
            children.Add(c);
            c.container = this;
        }
    }
}
