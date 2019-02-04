using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        testEntities1 db = new testEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               Users u = (Users)Session["user"];
                if ( u == null) 
                    Response.Redirect("Login.aspx");
            }

        }
    }
}