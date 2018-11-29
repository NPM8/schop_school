using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopSchoolv4
{
    public partial class Login : System.Web.UI.Page
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


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = this.connect();

            string email = txtEmail.Text;
            string passw = iPassword.Text;
            MySqlCommand comm3 = conn.CreateCommand();
            comm3.CommandText = "SELECT id, password FROM users WHERE login='" + email + "'";
            MySqlDataReader red = comm3.ExecuteReader();
            int id = 0;
            string pass = "";
            while (red.Read())
            {
                id = (int)red["id"];
                pass = (string)red["password"];
            }
            if (id == 0)
            {
                lLogMess.Text = "Błędny login";
                lLogMess.Visible = true;
            } else
            {
                if (pass == passw)
                {
                    Session["id"] = (string)id.ToString();
                    FormsAuthentication.RedirectFromLoginPage(lLogMess.Text, Persist.Checked);
                    Response.Redirect("/");
                } else
                {
                    lLogMess.Text = "Błędny login";
                    lLogMess.Visible = true;
                }
            }
            
        }
    }
}