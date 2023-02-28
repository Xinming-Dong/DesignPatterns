namespace ChainOfResponsibility
{
    public static class Go
    {
        static void Main()
        {
            var panel = new Panel();
            // panel.modalHelpText = "This panel does ...";
            var dialog = new Dialog();
            dialog.wikiPageURL = "http://...";

            dialog.Add(panel);

            panel.showHelp();
        }
    }
}