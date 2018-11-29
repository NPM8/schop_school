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
    public partial class EditProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("ProductList.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    ID = Request.QueryString["id"];
                    MySqlConnection conn = this.connect();

                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "SELECT * FROM products WHERE id=" + ID;

                    MySqlDataReader read = comm.ExecuteReader();
                    string tmp = "";
                    while (read.Read())
                    {
                        txtName.Text = (string)read["product-name"];
                        txtDescription.Text = (string)read["description"];
                        txtCost.Text = (string)read["cost"];
                    }
                    txtName.Text = tmp;
                }
            }
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
        public ICollection<Category> GetCategories()
        {
            ICollection<Category> tmp = new List<Category>();

            MySqlConnection conn = this.connect();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT * FROM category";
            MySqlDataReader read = comm.ExecuteReader();

            while (read.Read())
            {
                Category tmp2 = new Category();
                tmp2.ID = (int)read["id"];
                tmp2.Name = read["name"].ToString();
                tmp.Add(tmp2);
            }
            return tmp;
        }

    }
}