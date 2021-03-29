using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;

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

                    reader.Close();
                    cmd.Dispose();
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

                if (!reader.IsClosed) reader.Close();
                reader.Dispose();
                con.Close();
                return availableServices;
            }
            catch (SQLiteException e)
            {
                Debug.Print(e.Message);
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

                    reader.Close();
                    cmd.Dispose();

                    cmd = new SQLiteCommand(availableDimensionsQuery, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                        for (var i = 0; reader.Read(); i++)
                            availableDimensions[i] = new string[] { reader.GetString(0), reader.GetDouble(1).ToString() };
                }
                if (!reader.IsClosed) reader.Close();
                reader.Dispose();
                con.Close();
                return availableDimensions;
            }
            catch (SQLiteException e)
            {
                Debug.Print(e.Message);
                return null;
            }

        }

        public OrderModel[] GetAllOrders()
        {
            OrderModel[] orders = null;

            try
            {
                var query = $"SELECT COUNT(order_id) FROM orders";

                con.Open();

                var cmd = new SQLiteCommand(query, con);
                var reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    var orderCount = reader.GetInt32(0);
                    orders = new OrderModel[orderCount];

                    reader.Close();
                    cmd.Dispose();

                    query = "SELECT " +
                        "order_id, first_name, last_name, " +
                        "phone_number, service_type, dimensions, quantity " +
                        "FROM orders " +
                        "INNER JOIN users ON orders.user_id=users.id " +
                        "INNER JOIN services ON orders.service_id=services.id";

                    cmd = new SQLiteCommand(query, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                        for (var i = 0; reader.Read(); i++)
                        {
                            orders[i] = new OrderModel(
                                orderId: reader.GetInt32(0),
                                clientName: $"{reader.GetString(1)} {reader.GetString(2)}",
                                phoneNumber: reader.GetString(3),
                                serviceType: reader.GetString(4),
                                dimensions: reader.GetString(5),
                                quantity: reader.GetInt32(6),
                                image: null
                                );

                        }

                    reader.Close();
                    reader.Dispose();
                    cmd.Dispose();

                    for (var i = 0; i < orderCount; i++)
                    {
                        query = $"SELECT image price FROM orders WHERE order_id = '{orders[i].orderId}'";
                        cmd = new SQLiteCommand(query, con);
                        orders[i].image = (byte[])cmd.ExecuteScalar();
                    }

                    cmd.Dispose();

                }
                else
                {
                    reader.Close();
                }
                con.Close();
                return orders;
            }
            catch (SQLiteException e)
            {
                Debug.Print(e.Message);
                return null;
            }

        }

        public bool PlaceOrder(String email, String serviceType, String dimensions, Double quantity, byte[] fileBytes)
        {

            try
            {
                var queryString = $"SELECT id FROM services" +
                    $" WHERE service_type = '{serviceType}' and dimensions = '{dimensions}'";

                con.Open();
                var cmd = new SQLiteCommand(queryString, con);

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    var serviceId = reader.GetInt32(0);
                    reader.Close();
                    Debug.Print($"serviceId is {serviceId}");

                    cmd.Dispose();
                    queryString = $"SELECT id FROM users WHERE email = '{email}'";
                    cmd = new SQLiteCommand(queryString, con);
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        var userId = reader.GetInt32(0);
                        reader.Close();

                        Debug.Print($"userId is {userId}");


                        queryString = $"INSERT INTO orders (user_id, service_id, quantity, image) " +
                        $"VALUES('{userId}', '{serviceId}', '{quantity}', (@file)); ";

                        cmd.CommandText = queryString;
                        cmd.Parameters.Add("@file", DbType.Binary, 20).Value = fileBytes;

                        cmd.ExecuteNonQuery();

                        Debug.Print("Order successfully placed");
                        con.Close();
                        cmd.Dispose();
                    }
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