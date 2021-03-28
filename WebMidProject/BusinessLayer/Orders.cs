using System;
using System.Data.SQLite;


namespace WebMidProject.BusinessLayer
{
    public class Orders : DataAccess
    {
        public String[] GetAvailableOrders()
        {
            String[] availableServices = null;
            
            try
            {
                var availableServicesCount = "SELECT COUNT(DISTINCT service_type) FROM services";
                var availableServiceTypesQuery = "SELECT DISTINCT service_type FROM services";

                con.Open();

                var cmd = new SQLiteCommand(availableServicesCount, con);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    var servicesCount = reader.GetInt32(0);
                    availableServices = new String[reader.GetInt32(0)];

                    cmd = new SQLiteCommand(availableServiceTypesQuery, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        for (var i = 0; reader.Read(); i++)
                        {
                            availableServices[i] = reader.GetString(0);
                        }
                    }
                }
                con.Close();
                return availableServices;
            }
            catch (SQLiteException e)
            {
                return null;
            }

        }
    }
}