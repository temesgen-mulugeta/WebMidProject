using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;

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
                reader.Close();
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
                reader.Close();
                con.Close();
                return availableDimensions;
            }
            catch (SQLiteException e)
            {
                return null;
            }

        }

        public bool PlaceOrder(String serviceType, String dimensions, Double quantity, byte[] fileBytes)
        {
            try
            { 
                var serviceTypeIdQuery = $"SELECT id FROM services" +
                    $" WHERE service_type = '{serviceType}' and dimensions = '{dimensions}'";

                con.Open();
                var cmd = new SQLiteCommand(serviceTypeIdQuery, con);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    var serviceId = reader.GetInt32(0);
                    Debug.Print($"serviceId id {serviceId}");
                    reader.Close();



                    var placeOrderQuery = $"INSERT INTO orders (service_id, quantity, image) " +
                    $"VALUES('{serviceId}', '{quantity}', (@file)); ";

                    cmd.CommandText = placeOrderQuery;
                    cmd.Parameters.Add("@file", DbType.Binary, 20).Value = fileBytes;


                    cmd.ExecuteNonQuery();

                    Debug.Print("YESSS");

                    con.Close();

                    //binaryReader.Close();
                   // fileStream.Close();
                }
                return true;

            }
            catch (SQLiteException e)
            {
                Debug.Print(e.Message);
                return false;
            }

        }
    }

   
    
}