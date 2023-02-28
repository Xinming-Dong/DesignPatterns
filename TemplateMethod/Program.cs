namespace TemplateMethod
{
    public static class Go
    {
        static void Main()
        {
            var textMiner = new TxtDataMiner();
            textMiner.Mine("D:\\DesignPatterns\\TemplateMethod\\TextFile1.txt");

            var csvMiner = new CsvDataMiner();
            csvMiner.Mine("D:\\DesignPatterns\\TemplateMethod\\TextFile2.csv");
        }
    }
}