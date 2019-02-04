using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class urunler : System.Web.UI.Page
    {
        testEntities1 db = new testEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            var urun = db.Urunler.Select(I => I);

            GridView1.DataSource = urun.ToList();
            GridView1.DataBind();
        }
    }
}