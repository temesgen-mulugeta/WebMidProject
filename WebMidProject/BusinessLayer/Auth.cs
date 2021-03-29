using System.Data.SQLite;
using System.Diagnostics;

namespace WebMidProject.BusinessLayer
{
    public class Auth : DataAccess
    {
        public bool SignUp(string name, string phoneNumber, string email, string password)
        {
            try
            {
                var names = name.Split(' ');
                var signUpQuery = $"INSERT INTO users (first_name, last_name, phone_number, email, password) " +
                    $"VALUES ('{names[0]}','{names[1]}','{phoneNumber}','{email}','{password}');";

                con.Open();
                var cmd = new SQLiteCommand(signUpQuery, con);
                cmd.ExecuteScalar();
            }
            catch (SQLiteException e)
            {
                Debug.Print(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

            return true;
        }
        public bool Login(string email, string password, string role)
        {
            try
            {
                var signInQuery = $"SELECT 1 FROM users WHERE role = '{role}' and email = '{email}' and password = '{password}'";

                con.Open();
                var cmd = new SQLiteCommand(signInQuery, con);
                var reader = cmd.ExecuteReader();
                var accountExists = reader.HasRows;
                reader.Close();
                con.Close();
                Debug.Print($"userExists: {accountExists}");
                return accountExists;


            }
            catch (SQLiteException e)
            {
                Debug.Print(e.Message);
                return false;
            }

        }
    }
}