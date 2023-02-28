namespace TemplateMethod
{
    public class TxtDataMiner : DataMiner
    {
        private string content = "";

        protected override void CloseFile()
        {
        }

        protected override string ExtractData()
        {
            return content.Replace(" ", String.Empty);
        }

        protected override void OpenFile(string path)
        {
            this.content = File.ReadAllText(path);
        }
    }
}
