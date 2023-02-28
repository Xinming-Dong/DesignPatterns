using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Component : ComponentWithContestualHelp
    {
        private string? toolTipText;

        // the upper level in the chain
        public Container container;
        public virtual void showHelp()
        {
            if (toolTipText !=null)
            {
                Console.WriteLine(toolTipText);
            }
            else
            {
                container.showHelp();
            }
        }
    }
}
