using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;

namespace WebMidProject.BusinessLayer
{
    public class DataAccess
    {
        readonly protected SQLiteConnection con;
        public DataAccess()
        {
            string DBpath = $"{AppContext.BaseDirectory}\\DB\\OnlinePrintingService.db";
            string connectionString = $"Data Source={DBpath}";
            Debug.Print(AppContext.BaseDirectory);
            con = new SQLiteConnection(connectionString);
        }



    }
}