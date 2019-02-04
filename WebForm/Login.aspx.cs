using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class Login : System.Web.UI.Page
    {   testEntities1 db = new testEntities1();
        string username, password;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            username = TextBox1.Text;
            password = TextBox2.Text;
            var user = db.Users.Where(I => I.email == username && I.password == password).Select(I => I).FirstOrDefault();

            if (user != null)
            {

                string ip = HttpContext.Current.Request.UserHostAddress;
                user.SessionId = Session.SessionID;
                user.ipAddress = ip;
                user.lastLogin = DateTime.Now;
                user.loginCount = user.loginCount + 1;
                user.webBrowser = HttpContext.Current.Request.Browser.Browser;
                db.SaveChanges();
                Session.Add("user", user);
                Response.Redirect("AnaSayfa.aspx");
            }
        }

       
    }
}