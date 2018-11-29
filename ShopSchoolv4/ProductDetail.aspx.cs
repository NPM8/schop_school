using MySql.Data.MySqlClient;
using ShopSchoolv4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopSchoolv4
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        private Product product;
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;uid=root;password=toor;database=shopschool";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            MySqlCommand comm = conn.CreateCommand();

            comm.CommandText = "SELECT *  FROM products WHERE id = "+ Request.QueryString["productId"];

            MySqlDataReader render = comm.ExecuteReader();

            Product tmp2 = new Product();
            while (render.Read())
            {

                tmp2.ID = (int)render["id"];
                tmp2.ImgUrl = (string)render["product-image"];
                tmp2.ProductName = (string)render["product-name"];
                tmp2.Description = (string)render["description"];
                tmp2.Cost = (double)render["cost"];
                Console.Write(tmp2.ImgUrl);

            }

            Name.Text = tmp2.ProductName;
            ProdImg.ImageUrl = "/Catalogue/Images/" + tmp2.ImgUrl;
            Desc.Text = tmp2.Description;
            Price.Text = "Cena: " + String.Format("{0:c} zł", tmp2.Cost);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }
    }
}