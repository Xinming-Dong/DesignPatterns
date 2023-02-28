using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Dialog : Container
    {
        public string wikiPageURL;

        public override void showHelp()
        {
            if (wikiPageURL != null) 
            {
                Console.WriteLine("Dialog: " + wikiPageURL);
            }
            else
            {
                base.showHelp();
            }
        }
    }
}
