using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class CsvDataMiner : DataMiner
    {
        private StreamReader? reader;

        protected override void CloseFile()
        {
            if (this.reader != null)
            {
                this.reader.Dispose();
            }
        }

        protected override string ExtractData()
        {
            var content = this.reader.ReadToEnd();
            return content.Replace(", ", "||");
        }

        protected override void OpenFile(string path)
        {
            this.reader = new StreamReader(path);
        }
    }
}
