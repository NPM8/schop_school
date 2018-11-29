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
    public partial class UserPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("/");
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

        public ICollection<Models.User> GetUsers()
        {
            Console.Write("test");
            MySqlConnection conn = this.connect();
            ICollection<Models.User> tmp = new List<Models.User>();

            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT id, login, surname, name, isadmin FROM users";

            MySqlDataReader read = comm.ExecuteReader();

            while (read.Read())
            {
                Models.User tmp2 = new Models.User();
                tmp2.ID = (int)read["id"];
                tmp2.isAdmin = read["isadmin"].ToString();
                tmp2.Login = (string)read["login"];
                tmp2.Surname = (string)read["surname"];
                tmp2.Name = (string)read["name"];

                tmp.Add(tmp2);
            }

            return tmp;
        }
    }
}