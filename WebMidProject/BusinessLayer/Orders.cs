using System;
using System.Data.SQLite;


namespace WebMidProject.BusinessLayer
{
    public class Orders : DataAccess
    {
        public String[] GetAvailableOrdersTypes()
        {
            String[] availableServices = null;
            
            try
            {
                var availableServicesCount = "SELECT COUNT(DISTINCT service_type) AS Count FROM services";
                var availableServiceTypesQuery = "SELECT DISTINCT service_type FROM services";

                con.Open();

                var cmd = new SQLiteCommand(availableServicesCount, con);
                var reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    var servicesCount = reader.GetInt32(0);
                    availableServices = new String[servicesCount];

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
        public String[][] GetAvailableDimensions(String serviceType)
        {
            String[][] availableDimensions = null;

            try
            {
                var availableDimensionsCountQuery = $"SELECT COUNT(dimensions) FROM services WHERE service_type = '{serviceType}'";
                var availableDimensionsQuery = $"SELECT dimensions, price FROM services WHERE service_type = '{serviceType}'";

                con.Open();

                var cmd = new SQLiteCommand(availableDimensionsCountQuery, con);
                var reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    var dimensionsCount = reader.GetInt32(0);
                    availableDimensions = new String[dimensionsCount][];

                    cmd = new SQLiteCommand(availableDimensionsQuery, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        for (var i = 0; reader.Read(); i++)
                        {
                            availableDimensions[i] = new string[] { reader.GetString(0), reader.GetDouble(1).ToString()};
                        }
                    }
                }
                con.Close();
                return availableDimensions;
            }
            catch (SQLiteException e)
            {
                return null;
            }

        }
    }

   
    
}