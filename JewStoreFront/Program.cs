using System;
using System.Windows.Forms;

namespace JewStoreFront
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OpenFileDialog jsonFileDialog = new OpenFileDialog();
            jsonFileDialog.Filter = "JSON Files|*.json";
            if (jsonFileDialog.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
                return;
            }
            
            Application.Run(new FrontForm(jsonFileDialog.FileName));
        }
    }
}
