using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using ShopSchoolv4.Models;

namespace ShopSchoolv4.User.Admin
{
    public partial class AddProduct : System.Web.UI.Page
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/Catalogue/Images/");
            if (fileUploadImg.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(fileUploadImg.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }
            if (fileOK)
            {
                try
                {
                    // Save to Images folder.
                    fileUploadImg.PostedFile.SaveAs(path + fileUploadImg.FileName);
                }
                catch (Exception ex)
                {
                    
                }

                // Add product data to DB.
                MySqlConnection conn = this.connect();
                MySqlCommand comm2 = conn.CreateCommand();
                string nazwa = txtName.Text;
                string opis = txtDescription.Text;
                string cena = txtCost.Text;
                string file = fileUploadImg.FileName;
                string category = catDS.SelectedValue;

                comm2.CommandText = $"INSERT INTO `products` ( `product-name`, description, cost, `product-image`, `category-id`) VALUES ('{nazwa}','{opis}','{cena}', '{file}',{category})";
                comm2.ExecuteNonQuery();
                Response.Redirect("CategoryList.aspx");
            }
            
        }
    }
}