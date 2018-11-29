using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopSchoolv4
{
    public partial class Register : System.Web.UI.Page
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

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pass = iPassword.Text;
            string email = txtEmail.Text;
            string srn = txtSurN.Text;

            if (name != "" && pass != "" && email != "" && srn != "")
            {
                MySqlConnection conn = connect();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT count(*) FROM users WHERE login='" + email + "'";
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 0)
                {
                    MySqlCommand comm2 = conn.CreateCommand();
                    comm2.CommandText = "INSERT INTO `users` (`login`,`password`,`surname`,`name`) VALUES ('" + email + "','" + pass + "','" + srn + "','" + name + "')";
                    comm2.ExecuteNonQuery();

                    MySqlCommand comm3 = conn.CreateCommand();
                    comm3.CommandText = "SELECT id FROM users WHERE login='" + email + "'";
                    MySqlDataReader red = comm3.ExecuteReader();
                    int id = 0;
                    while (red.Read())
                    {
                        id = (int)red["id"];
                    }
                    Session["id"] = (string)id.ToString();
                    Response.Redirect("/");
                }
                else
                {
                    lRegMess.Text = "Użytkownik o podanym mailu już istnieje";
                    lRegMess.Visible = true;
                }
            }
        }
    }
}