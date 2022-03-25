using System.Media;
namespace BingSlamet
{
    internal static class Program
    {
        static public Main F1 = new Main();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            F1.StartPosition = FormStartPosition.CenterParent;
            F1.ShowDialog();
        }
    }


}