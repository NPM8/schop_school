using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopSchoolv4
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("/UserList.aspx");
            }
            else
            {
                MySqlConnection conn = connect();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "DELETE FROM users WHERE id=" + Request.QueryString["id"];
                int test = command.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine(test);
                Response.Redirect("/UserList.aspx");
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
    }
}