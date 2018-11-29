using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShopSchoolv4.Models;

namespace ShopSchoolv4
{
    public partial class ProductsByCategory : System.Web.UI.Page
    {
        public String Name { get; set; }
        public String Id { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Name = "";
            Id = Request.QueryString["id"];
            MySqlConnection conn = this.connect();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT name FROM category WHERE id=" + Id;
            MySqlDataReader reader = comm.ExecuteReader();
            while(reader.Read())
            {
                Name = (string)reader["name"];
            }
            Page.Title = "Kategoria "+Name;
            Page.DataBind();
        }

        public MySqlConnection connect()
        {
            string myconnection = "server=localhost;port=3306;uid=root;password=toor;database=shopschool";

            MySqlConnection connection = new MySqlConnection(myconnection);

            try
            {

                connection.Open();
                Console.WriteLine("Connected");
                return connection;

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Error");
            }
            return null;
        }

        public ICollection<Product> GetProducts()
        {
            ICollection<Product> tmp = new List<Product>();

            MySqlConnection conn = this.connect();
            MySqlCommand comm = conn.CreateCommand();

            comm.CommandText = $"SELECT `id`,`product-image`,`product-name`,`cost`  FROM products WHERE (`category-id` = {Id})";

            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Product tmpProduct = new Product();
                tmpProduct.Cost = (Double)reader["cost"];
                tmpProduct.ImgUrl = (string)reader["product-image"];
                tmpProduct.ID = (int)reader["id"];
                tmpProduct.ProductName = (string)reader["product-name"];
                tmp.Add(tmpProduct);
            }
            conn.Close();
            return tmp;
        }
    }
}