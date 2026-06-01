using System;
using System.Windows.Forms;
using ClothesShop.DAL.Data;

namespace ClothesShop.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Auto-initialize SQL Database
            try
            {
                DatabaseHelper.InitializeDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize database:\n{ex.Message}\n\nPlease ensure SQL Server LocalDB is running and accessible.", 
                    "Database Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Standard WinForms configuration
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}