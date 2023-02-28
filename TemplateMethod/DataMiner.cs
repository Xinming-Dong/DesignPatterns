using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class DataMiner
    {
        public void Mine(string path)
        {
            this.OpenFile(path);
            var content = this.ExtractData();
            this.SendReport(content);
            this.CloseFile();
        }

        protected abstract void OpenFile(string path);

        protected abstract string ExtractData();

        protected virtual void SendReport(string content)
        {
            Console.WriteLine("Report Content: ");
            Console.WriteLine(content);
        }

        protected abstract void CloseFile();
    }
}
