using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using ShopSchoolv4.Models;

namespace ShopSchoolv4
{
    public partial class ProductsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            comm.CommandText = "SELECT * FROM products";

            MySqlDataReader read = comm.ExecuteReader();

            while (read.Read())
            {
                Product tmp2 = new Product();
                tmp2.ID = (int)read["id"];
                tmp2.ProductName = read["product-name"].ToString();
                tmp2.Cost = (double)read["cost"];
                tmp2.ImgUrl = (string)read["product-image"];
                tmp2.Description = (string)read["description"];

                tmp.Add(tmp2);
            }

            return tmp;
        }
    }
}