using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopSchoolv4.Connectors
{
    public class Database
    {

        private MySqlConnection conn;

        private string connectionString;

        public Database()
        {
            connectionString = "server=localhost;port=3306;uid=root;password=toor;database=schoolshop";
            conn = new MySqlConnection(connectionString);
        }

        public void insert (string command)
        {
            try
            {
                conn.Open();

                MySqlCommand comm = conn.CreateCommand();

                comm.CommandText = command;

                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Error");
            }
        }

        public MySqlDataReader reader(string command)
        {
            try
            {
                conn.Open();

                MySqlCommand comm = conn.CreateCommand();

                comm.CommandText = command;

                MySqlDataReader reader = comm.ExecuteReader();
                return reader;

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Error");
                return null;
            }
        }
    }
}