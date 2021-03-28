﻿using System.Data.SQLite;
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
                con.Close();
            }
            catch (SQLiteException e)
            {

                return false;
            }

            return true;
        }
        public bool Login(string email, string password)
        {
            try
            {
                var signInQuery = $"SELECT 1 FROM users WHERE email = '{email}' and password = '{password}'";

                con.Open();
                var cmd = new SQLiteCommand(signInQuery, con);
                var reader = cmd.ExecuteReader();
                var userExists = reader.HasRows;
                con.Close();
                Debug.Print($"userExists: {userExists}");
                return userExists;


            }
            catch (SQLiteException e)
            {
                return false;
            }

        }
    }
}