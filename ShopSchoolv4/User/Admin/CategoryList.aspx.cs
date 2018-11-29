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
    public partial class CategoryList : System.Web.UI.Page
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

        public ICollection<Category> GetCategories()
        {
            Console.Write("test");
            MySqlConnection conn = this.connect();
            ICollection<Category> tmp = new List<Category>();

            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT * FROM category";

            MySqlDataReader read = comm.ExecuteReader();

            while (read.Read())
            {
                Category tmp2 = new Category();
                tmp2.ID = (int)read["id"];
                tmp2.Name = (string)read["name"];

                tmp.Add(tmp2);
            }

            return tmp;
        }
    }
}