using System.Data.SQLite;

namespace WebMidProject.BusinessLayer
{
    public class DataAccess
    {
        readonly protected SQLiteConnection con;
        public DataAccess()
        {
            string connectionString = "Data Source=C:\\Users\\user\\Desktop\\" +
                "WebMidDatabase\\OnlinePrintingService.db";
            con = new SQLiteConnection(connectionString);
        }
      
    }
}