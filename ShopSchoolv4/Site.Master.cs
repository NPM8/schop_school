using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopSchoolv4
{
    public partial class SiteMaster : MasterPage
    {
        public bool LogedIn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Session["id"] as string))
            {
                this.LogedIn = true;
            } else
            {
                this.LogedIn = false;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Search.aspx?name=" + txtSearch.Text);
        }
    }
}