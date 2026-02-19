using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace Billard_Tracker.Data
{
    public class Database
    {
        public Database()
        {
            var baseDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "BillardTracker");

            Directory.CreateDirectory(baseDir);

            var dbPath = Path.Combine(baseDir, "billard_tracker.db");
            var connectionString = $"Data Source={dbPath};";

            try
            {
                using var connection = new SqliteConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connection good");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}");
                MessageBox.Show(dbPath);
            }
        }
    }
}