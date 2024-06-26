using BBB.ClientRESTHelpers;
using System.Diagnostics;

namespace BBB
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            RestServiceMasterEndpointRoot.Instance.Mode = RestServiceMasterEndpointRoot.Modes.PROD;
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}