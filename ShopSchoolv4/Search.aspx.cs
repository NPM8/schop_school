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
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["name"] == null)
            {
                Response.Redirect("/Default.aspx");
            }
        }
        public ICollection<Product> GetProducts()
        {
            ICollection<Product> tmp = new List<Product>();
            string connectionString = "server=localhost;port=3306;uid=root;password=toor;database=shopschool";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            MySqlCommand comm = conn.CreateCommand();

            comm.CommandText = "SELECT `id`,`product-image`,`product-name`,`cost`  FROM products WHERE `product-name` Like '%"+Request.QueryString["name"]+"%'";

            MySqlDataReader render = comm.ExecuteReader();

            while (render.Read())
            {
                Product tmp2 = new Product();

                tmp2.ID = (int)render["id"];
                tmp2.ImgUrl = (string)render["product-image"];
                tmp2.ProductName = (string)render["product-name"];
                tmp2.Cost = (double)render["cost"];
                Console.Write(tmp2.ImgUrl);

                tmp.Add(tmp2);

            }
            return tmp;
        }
    }
}