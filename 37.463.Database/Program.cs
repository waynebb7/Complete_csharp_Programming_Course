﻿using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace _37._463.Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=WBB_DESKTOP\SQLEXPRESS;
                                        Initial Catalog=ExampleDatabase;
                                        User ID=Wayne;
                                        Password=;
                                        Trusted_Connection=Yes;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Debug.WriteLine("Connected to the Server!");
            SqlCommand command = new SqlCommand();
            command.Connection =  connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM dbo.People";
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    Debug.WriteLine(reader.GetString(1) + "-" + reader.GetString(2));
                }
            }

            connection.Close();
        }
    }
}