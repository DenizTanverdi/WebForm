using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class WebForm : System.Web.UI.Page
    {
             testEntities1 db = new testEntities1();
        string username, password;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            username = TextBox1.Text;
            password = TextBox2.Text;
            var user = db.Users.Where(I => I.email == username && I.password == password).Select(I => I).FirstOrDefault();

            if (user!=null)
            {
                user.SessionId = Session.SessionID;
                db.SaveChanges();
            }
        }
    }
}