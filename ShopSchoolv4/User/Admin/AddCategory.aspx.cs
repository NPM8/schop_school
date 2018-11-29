using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopSchoolv4
{
    public partial class AddCategory : System.Web.UI.Page
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = this.connect();

            string nazwa = txtName.Text;
            MySqlCommand comm3 = conn.CreateCommand();
            comm3.CommandText = "SELECT * FROM category WHERE name='" + nazwa + "'";
            int id = 0;
            string pass = "";
            using(MySqlDataReader red = comm3.ExecuteReader())
            {
                while (red.Read())
                {
                    id = (int)red["id"];
                    pass = (string)red["password"];
                }
            }

            if (id == 0)
            {
                MySqlCommand comm2 = conn.CreateCommand();
                comm2.CommandText = "INSERT INTO `category` (`name`) VALUES ('" + nazwa + "')";
                comm2.ExecuteNonQuery();
                Response.Redirect("/CategoryList.aspx");
            }
            else
            {
                lLogMess.Text = "Kategeria istnieje";
                lLogMess.Visible = true;
            }
        }
    }
}