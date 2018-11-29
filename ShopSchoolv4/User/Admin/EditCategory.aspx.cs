using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopSchoolv4
{
    public partial class EditCategory : System.Web.UI.Page
    {
        private string ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("CategoryList.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    ID = Request.QueryString["id"];
                    MySqlConnection conn = this.connect();

                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "SELECT * FROM category WHERE id=" + ID;

                    MySqlDataReader read = comm.ExecuteReader();
                    string tmp = "";
                    while (read.Read())
                    {
                        tmp = (string)read["name"];
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

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = this.connect();

            MySqlCommand comm = conn.CreateCommand();
            System.Diagnostics.Debug.WriteLine(txtName.Text);
            comm.CommandText = "UPDATE category SET `name` = '" + txtName.Text + "' WHERE id = "+ Request.QueryString["id"];
            int test = comm.ExecuteNonQuery();
            
            System.Diagnostics.Debug.WriteLine(test);
            conn.Close();
        }
    }
}