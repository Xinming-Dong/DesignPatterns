using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Panel : Container
    {
        public string modalHelpText;

        public override void showHelp()
        {
            if (modalHelpText!= null)
            {
                Console.WriteLine("Panel: " + modalHelpText);
            }
            else
            {
                base.showHelp();
            }
        }
    }
}
